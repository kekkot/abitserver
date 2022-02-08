using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class VerificationDocument
    {
        public VerificationDocument()
        {
            AbiturientVerificationDocuments = new HashSet<AbiturientVerificationDocument>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float? Order { get; set; }

        public virtual ICollection<AbiturientVerificationDocument> AbiturientVerificationDocuments { get; set; }
    }
}
