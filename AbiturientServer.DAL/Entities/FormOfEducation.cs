using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class FormOfEducation
    {
        public FormOfEducation()
        {
            Applications = new HashSet<Application>();
            SpecialtyFormOfEducations = new HashSet<SpecialtyFormOfEducation>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float? Order { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<SpecialtyFormOfEducation> SpecialtyFormOfEducations { get; set; }
    }
}
