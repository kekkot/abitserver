using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Enroll
    {
        public Enroll()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public string DepartmentCode { get; set; }
        public string ContestCode { get; set; }

        public virtual Contest ContestCodeNavigation { get; set; }
        public virtual Department DepartmentCodeNavigation { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
