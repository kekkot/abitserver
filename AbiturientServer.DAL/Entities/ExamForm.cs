using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class ExamForm
    {
        public ExamForm()
        {
            AbiturientExams = new HashSet<AbiturientExam>();
            ExamExamForms = new HashSet<ExamExamForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AbiturientExam> AbiturientExams { get; set; }
        public virtual ICollection<ExamExamForm> ExamExamForms { get; set; }
    }
}
