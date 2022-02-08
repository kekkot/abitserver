using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class NoExam
    {
        public NoExam()
        {
            AbiturientNoExams = new HashSet<AbiturientNoExam>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AbiturientNoExam> AbiturientNoExams { get; set; }
    }
}
