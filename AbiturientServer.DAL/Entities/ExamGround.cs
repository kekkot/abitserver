using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class ExamGround
    {
        public ExamGround()
        {
            AbiturientExams = new HashSet<AbiturientExam>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }

        public virtual ICollection<AbiturientExam> AbiturientExams { get; set; }
    }
}
