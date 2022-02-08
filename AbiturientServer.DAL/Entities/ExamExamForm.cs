using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class ExamExamForm
    {
        public int ExamFormId { get; set; }
        public int ExamCode { get; set; }

        public virtual Exam ExamCodeNavigation { get; set; }
        public virtual ExamForm ExamForm { get; set; }
    }
}
