using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbiturientServer.PL.API.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "UserName - обязательный параметр")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password - обязательный параметр")]
        public string Password { get; set; }
    }
}
