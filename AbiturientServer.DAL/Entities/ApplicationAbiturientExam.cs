using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class ApplicationAbiturientExam
    {
        public int ApplicationId { get; set; }
        public int AbiturientExamId { get; set; }

        public virtual AbiturientExam AbiturientExam { get; set; }
        public virtual Application Application { get; set; }
    }
}
