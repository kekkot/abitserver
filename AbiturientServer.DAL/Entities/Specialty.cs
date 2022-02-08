using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Specialty
    {
        public Specialty()
        {
            Applications = new HashSet<Application>();
            SpecialtyContests = new HashSet<SpecialtyContest>();
            SpecialtyDetails = new HashSet<SpecialtyDetail>();
            SpecialtyExams = new HashSet<SpecialtyExam>();
            SpecialtyFormOfEducations = new HashSet<SpecialtyFormOfEducation>();
        }

        public string Code { get; set; }
        public string DepartmentCode { get; set; }
        public int EducationLevelId { get; set; }

        public virtual Department DepartmentCodeNavigation { get; set; }
        public virtual EducationLevel EducationLevel { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<SpecialtyContest> SpecialtyContests { get; set; }
        public virtual ICollection<SpecialtyDetail> SpecialtyDetails { get; set; }
        public virtual ICollection<SpecialtyExam> SpecialtyExams { get; set; }
        public virtual ICollection<SpecialtyFormOfEducation> SpecialtyFormOfEducations { get; set; }
    }
}
