using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbiturientServer.PL.API.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "UserName - обязательный параметр")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email - обязательный параметр")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password - обязательный параметр")]
        public string Password { get; set; }

        [Required(ErrorMessage = "PasswordConfirmation - обязательный параметр")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirmation { get; set; }

        [Required(ErrorMessage = "PhoneNumber - обязательный параметр")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string PhoneNumber { get; set; }
    }
}
