using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class User : IdentityUser
    {
        public User()
        {
            AbiturientAddedUsers = new HashSet<Abiturient>();
            AbiturientUpdatedUsers = new HashSet<Abiturient>();
            ApplicationAddedUsers = new HashSet<Application>();
            ApplicationUpdatedUsers = new HashSet<Application>();
        }

        public string DepartmentCode { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsBlocked { get; set; }
        public string BlockReason { get; set; }
        public virtual Department DepartmentCodeNavigation { get; set; }
        public virtual ICollection<Abiturient> AbiturientAddedUsers { get; set; }
        public virtual ICollection<Abiturient> AbiturientUpdatedUsers { get; set; }
        public virtual ICollection<Application> ApplicationAddedUsers { get; set; }
        public virtual ICollection<Application> ApplicationUpdatedUsers { get; set; }
    }
}
