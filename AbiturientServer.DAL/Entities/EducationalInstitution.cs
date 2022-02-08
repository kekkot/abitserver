using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class EducationalInstitution
    {
        public EducationalInstitution()
        {
            AbiturientEducations = new HashSet<AbiturientEducation>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AbiturientEducation> AbiturientEducations { get; set; }
    }
}
