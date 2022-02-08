using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class DocumentNoExam
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool Checked { get; set; }
        public int? AbiturientNoExamsId { get; set; }

        public virtual AbiturientNoExam AbiturientNoExams { get; set; }
    }
}
