using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class AbiturientEducation
    {
        public AbiturientEducation()
        {
            DocumentEducations = new HashSet<DocumentEducation>();
        }

        public int Id { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string GivenBy { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public string EducationalInstitutionCode { get; set; }
        public string EducationalDocumentCode { get; set; }
        public int AddressId { get; set; }
        public bool Checked { get; set; }

        public virtual Address Address { get; set; }
        public virtual EducationalDocument EducationalDocumentCodeNavigation { get; set; }
        public virtual EducationalInstitution EducationalInstitutionCodeNavigation { get; set; }
        public virtual Abiturient Abiturient { get; set; }
        public virtual ICollection<DocumentEducation> DocumentEducations { get; set; }
    }
}
