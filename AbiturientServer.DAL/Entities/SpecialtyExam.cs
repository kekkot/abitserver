using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class SpecialtyExam
    {
        public string SpecialtyCode { get; set; }
        public int ExamCode { get; set; }
        public int Priority { get; set; }
        public int MinimalScore { get; set; }

        public virtual Exam ExamCodeNavigation { get; set; }
        public virtual Specialty SpecialtyCodeNavigation { get; set; }
    }
}
