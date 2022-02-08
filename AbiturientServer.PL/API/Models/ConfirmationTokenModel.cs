using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbiturientServer.PL.API.Models
{
    public class ConfirmationTokenModel
    {
        [Required(ErrorMessage = "Email - обязательный параметр")]
        [EmailAddress(ErrorMessage ="Некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Token - обязательный параметр")]
        public string Token { get; set; }
    }
}
