using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Application
    {
        public Application()
        {
            ApplicationAbiturientExams = new HashSet<ApplicationAbiturientExam>();
            DocumentApprovals = new HashSet<DocumentApproval>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public bool IsOriginal { get; set; }
        public string ContestCode { get; set; }
        public string FormOfEducationCode { get; set; }
        public string SpecialtyCode { get; set; }
        public int AbiturientId { get; set; }
        public int? EnrollId { get; set; }
        public int StatusId { get; set; }
        public string AddedUserId { get; set; }
        public DateTime Added { get; set; }
        public string UpdatedUserId { get; set; }
        public DateTime Updated { get; set; }
        public string Remark { get; set; }
        public bool Checked { get; set; }

        public virtual Abiturient Abiturient { get; set; }
        public virtual User AddedUser { get; set; }
        public virtual Contest ContestCodeNavigation { get; set; }
        public virtual Enroll Enroll { get; set; }
        public virtual FormOfEducation FormOfEducationCodeNavigation { get; set; }
        public virtual Specialty SpecialtyCodeNavigation { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpdatedUser { get; set; }
        public virtual ICollection<ApplicationAbiturientExam> ApplicationAbiturientExams { get; set; }
        public virtual ICollection<DocumentApproval> DocumentApprovals { get; set; }
    }
}
