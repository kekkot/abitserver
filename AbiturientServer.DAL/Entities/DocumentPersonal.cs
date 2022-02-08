using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class DocumentPersonal
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool Checked { get; set; }
        public int? AbiturientVerificationDocumentId { get; set; }

        public virtual AbiturientVerificationDocument AbiturientVerificationDocument { get; set; }
    }
}
