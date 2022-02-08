using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class AbiturientVerificationDocument
    {
        public AbiturientVerificationDocument()
        {
            DocumentPersonals = new HashSet<DocumentPersonal>();
        }

        public int Id { get; set; }
        public int VerificationDocumentId { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string SubdivisCode { get; set; }
        public string GivenBy { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public bool Checked { get; set; }

        public virtual VerificationDocument VerificationDocument { get; set; }
        public virtual Abiturient Abiturient { get; set; }
        public virtual ICollection<DocumentPersonal> DocumentPersonals { get; set; }
    }
}
