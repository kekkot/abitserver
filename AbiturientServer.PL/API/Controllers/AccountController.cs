using AbiturientServer.BLL.Interfaces;
using AbiturientServer.BLL.Services;
using AbiturientServer.DAL.Entities;
using AbiturientServer.DAL.Interfaces;
using AbiturientServer.PL.API.JsonModels;
using AbiturientServer.PL.API.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.PL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMessageService _emailSender;
        private readonly IWebHostEnvironment _env;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager, IMessageService emailSender, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _env = env;
        }


        [HttpGet("Roles")] 
        public async Task<IActionResult> Roles()
        {
            List<IdentityRole> roles = await _roleManager.Roles.ToListAsync();
            List<string> roleNames = new List<string>();
            for(int i = 0; i < roles.Count; i++)
            {
                roleNames.Add(roles[i].Name);
            }
            return Ok(roleNames);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromQuery] RegisterModel userData)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            User user = new User { Email = userData.Email, UserName = userData.UserName, PhoneNumber = userData.PhoneNumber };
            IdentityResult result = await _userManager.CreateAsync(user, userData.Password);
            if (result.Succeeded)
            {
                _ = await _userManager.AddToRoleAsync(user, "Abiturient");
                string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                string confirmationLink = Url.Action("ConfirmEmail", "Account", new { token, email = user.Email }, Request.Scheme);
                string message = System.IO.File.ReadAllText(_env.WebRootPath + @"/emailTemplates/registrationConfirmationEmailTemplate.html", Encoding.UTF8);
                message = message.Replace("CONF_LINK_PLACEHOLDER", confirmationLink);
                await _emailSender.SendMessageAsync(user.Email, "Активация аккаунта", message);

                return Ok("Аккаунт успешно зарегистрирован! Письмо для подтверждения выслано на почту " + userData.Email + ".");
            }
            else
            {
                return BadRequest(new Error(result));
            }
        }

        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromQuery] ForgotPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            User user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest(new Error("UserNotFound", new string[] { "Пользователь не найден" }));
            }
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            string resetLink = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);
            //string message = "<a href=\"" + resetLink + "\">Нажмите чтобы продолжить восстановление пароля</a>";
            string message = System.IO.File.ReadAllText(_env.WebRootPath + @"/emailTemplates/passwordRecoveryEmailTemplate.html", Encoding.UTF8);
            message = message.Replace("PWD_RESET_LINK_PLACEHOLDER", resetLink);
            await _emailSender.SendMessageAsync(model.Email, "Восстановление пароля", message);



            return Ok("Сообщение с интрукциями по восстановлению пароля выслано на почту " + model.Email);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromQuery] LoginModel user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, true, false);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest(new Error("LoginFail", new string[] { "Неправильный логин и (или) пароль" }));
            }
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
    }
}
