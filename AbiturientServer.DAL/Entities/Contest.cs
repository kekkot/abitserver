using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Contest
    {
        public Contest()
        {
            Applications = new HashSet<Application>();
            Enrolls = new HashSet<Enroll>();
            SpecialtyContests = new HashSet<SpecialtyContest>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public float? Order { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Enroll> Enrolls { get; set; }
        public virtual ICollection<SpecialtyContest> SpecialtyContests { get; set; }
    }
}
