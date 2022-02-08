using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class EducationLevel
    {
        public EducationLevel()
        {
            Specialties = new HashSet<Specialty>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Specialty> Specialties { get; set; }
    }
}
