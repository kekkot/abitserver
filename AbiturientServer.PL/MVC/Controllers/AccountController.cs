using AbiturientServer.BLL.Interfaces;
using AbiturientServer.DAL.Entities;
using AbiturientServer.PL.API.Models;
using AbiturientServer.PL.MVC.ViewModels.Account;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.PL.MVC.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IWebHostEnvironment _env;
        private readonly IMessageService _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IMessageService emailSender, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _env = env;
        }



        [HttpGet("RecoveryPassword", Name = "MvcRecoveryPasswordGet")]
        public IActionResult RecoveryPassword()
        {
            return View("~/MVC/Views/Account/RecoveryPassword.cshtml");
        }

        [HttpPost("RecoveryPassword", Name = "MvcRecoveryPasswordPost")]
        public async Task<IActionResult> RecoveryPassword(RecoveryPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    //Todo: сделать норм ошибку
                    return View("~/MVC/Views/Shared/Error.cshtml");
                }
                string token = await _userManager.GeneratePasswordResetTokenAsync(user);
                string resetLink = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);
                string message = System.IO.File.ReadAllText(_env.WebRootPath + @"/emailTemplates/passwordRecoveryEmailTemplate.html", Encoding.UTF8);
                message = message.Replace("PWD_RESET_LINK_PLACEHOLDER", resetLink);
                await _emailSender.SendMessageAsync(model.Email, "Восстановление пароля", message);

                ViewBag.Message = "Письмо с инструкциями по восстановлению пароля отправлены на почту " + model.Email + ".";
                return View("~/MVC/Views/Shared/Result.cshtml");
            }
            return View("~/MVC/Views/Account/RecoveryPassword.cshtml", model);
        }



        [HttpGet("Register", Name = "MvcRegisterGet")]
        public IActionResult Register()
        {
            return View("~/MVC/Views/Account/Register.cshtml");
        }



        [HttpPost("Register", Name = "MvcRegisterPost")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.UserName, PhoneNumber = model.PhoneNumber };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    _ = await _userManager.AddToRoleAsync(user, "Abiturient");
                    string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    string confirmationLink = Url.Action("ConfirmEmail", "Account", new { token, email = user.Email }, Request.Scheme);
                    string message = System.IO.File.ReadAllText(_env.WebRootPath + @"/emailTemplates/registrationConfirmationEmailTemplate.html", Encoding.UTF8);
                    message = message.Replace("CONF_LINK_PLACEHOLDER", confirmationLink);
                    await _emailSender.SendMessageAsync(user.Email, "Активация аккаунта", message);

                    ViewBag.Message = "Аккаунт успешно зарегистрирован! Письмо для подтверждения выслано на почту " + model.Email + ".";
                    return View("~/MVC/Views/Shared/Result.cshtml");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View("~/MVC/Views/Account/Register.cshtml", model);
        }

        [HttpGet("Login", Name = "MvcLoginGet")]
        public IActionResult Login(string returnUrl = null)
        {
            return View("~/MVC/Views/Account/Login.cshtml", new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost("Login", Name = "MvcLoginPost")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View("~/MVC/Views/Account/Login.cshtml", model);
        }

        [HttpPost("Logout", Name = "MvcLogoutPost")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmationTokenModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest("Пользователь с таким именем не найден");
            }
            var result = await _userManager.ConfirmEmailAsync(user, model.Token);
            if(result.Succeeded)
            {
                ViewBag.Message = $"Акканут {model.Email} успешно активирован!";
                return View("~/MVC/Views/Shared/Result.cshtml");
            }
            else
            {
                //Todo: сделать страницу ошибки
                return View("~/MVC/Views/Shared/Error.cshtml");
            }
        }

        [HttpGet("ResetPassword")]
        public IActionResult ResetPassword([FromQuery] ConfirmationTokenModel model)
        {
            ResetPasswordViewModel viewModel = new ResetPasswordViewModel { Token = model.Token, Email = model.Email };
            return View("~/MVC/Views/Account/ResetPassword.cshtml", viewModel);
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/MVC/Views/Account/ResetPassword.cshtml", model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                View("~/MVC/Views/Shared/Error.cshtml"); //Todo: сделать нормальную страницу ошибки
            }
            var resetPassResult = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View("~/MVC/Views/Account/ResetPassword.cshtml");
            }
            ViewBag.Message = $"Пароль акканута {model.Email} успешно изменен!";
            return View("~/MVC/Views/Shared/Result.cshtml");
        }
    }
}
