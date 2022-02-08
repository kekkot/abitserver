using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Exam
    {
        public Exam()
        {
            AbiturientExams = new HashSet<AbiturientExam>();
            ExamExamForms = new HashSet<ExamExamForm>();
            SpecialtyExams = new HashSet<SpecialtyExam>();
        }

        public int Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AbiturientExam> AbiturientExams { get; set; }
        public virtual ICollection<ExamExamForm> ExamExamForms { get; set; }
        public virtual ICollection<SpecialtyExam> SpecialtyExams { get; set; }
    }
}
