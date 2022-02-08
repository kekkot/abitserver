using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class SpecialtyFormOfEducation
    {
        public string SpecialtyCode { get; set; }
        public string FormOfEducationCode { get; set; }

        public virtual FormOfEducation FormOfEducationCodeNavigation { get; set; }
        public virtual Specialty SpecialtyCodeNavigation { get; set; }
    }
}
