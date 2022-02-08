using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbiturientServer.PL.MVC.ViewModels.Account
{
    public class RecoveryPasswordViewModel
    {
        [Required(ErrorMessage = "Email - обязательный параметр")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
