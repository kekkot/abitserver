using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class AbiturientNoExam
    {
        public AbiturientNoExam()
        {
            DocumentNoExams = new HashSet<DocumentNoExam>();
        }

        public int Id { get; set; }
        public string NoExamsCode { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string GivenBy { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public bool Checked { get; set; }

        public virtual NoExam NoExamsCodeNavigation { get; set; }
        public virtual Abiturient Abiturient { get; set; }
        public virtual ICollection<DocumentNoExam> DocumentNoExams { get; set; }
    }
}
