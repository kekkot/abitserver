using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class DocumentExamGrade
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool Checked { get; set; }
        public int? AbiturientExamId { get; set; }

        public virtual AbiturientExam AbiturientExam { get; set; }
    }
}
