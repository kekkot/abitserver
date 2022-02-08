using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
            Enrolls = new HashSet<Enroll>();
            Specialties = new HashSet<Specialty>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public float Order { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Enroll> Enrolls { get; set; }
        public virtual ICollection<Specialty> Specialties { get; set; }
    }
}
