using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbiturientServer.PL.API.JsonModels
{
    public class Error
    {
        public Dictionary<string, List<string>> Errors { get; set; }

        public Error(IdentityResult target)
        {
            Errors = new Dictionary<string, List<string>>();

            foreach (IdentityError error in target.Errors)
            {
                List<string> descriptions = new List<string>();
                descriptions.Add(error.Description);
                Errors.Add(error.Code, descriptions);
            }
        }

        public Error(string code, string[] description)
        {
            Errors = new Dictionary<string, List<string>>();
            Errors.Add(code, description.ToList());
        }
    }
}
