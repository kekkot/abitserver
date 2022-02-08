using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class AbiturientExam
    {
        public AbiturientExam()
        {
            ApplicationAbiturientExams = new HashSet<ApplicationAbiturientExam>();
            DocumentExamGrades = new HashSet<DocumentExamGrade>();
        }

        public int Id { get; set; }
        public int Mark { get; set; }
        public int Year { get; set; }
        public int AbiturientId { get; set; }
        public int ExamCode { get; set; }
        public int ExamFormId { get; set; }
        public string ExamGroundCode { get; set; }
        public DateTime LastUpdate { get; set; }
        public int? EntranceGroup { get; set; }
        public bool Checked { get; set; }

        public virtual Abiturient Abiturient { get; set; }
        public virtual Exam ExamCodeNavigation { get; set; }
        public virtual ExamForm ExamForm { get; set; }
        public virtual ExamGround ExamGroundCodeNavigation { get; set; }
        public virtual ICollection<ApplicationAbiturientExam> ApplicationAbiturientExams { get; set; }
        public virtual ICollection<DocumentExamGrade> DocumentExamGrades { get; set; }
    }
}
