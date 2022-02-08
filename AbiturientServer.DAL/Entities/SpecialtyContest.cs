using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class SpecialtyContest
    {
        public string SpecialtyCode { get; set; }
        public string ContestCode { get; set; }

        public virtual Contest ContestCodeNavigation { get; set; }
        public virtual Specialty SpecialtyCodeNavigation { get; set; }
    }
}
