using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class DocumentPurposive
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool Checked { get; set; }
        public int? AbiturientPurposiveId { get; set; }

        public virtual AbiturientPurposive AbiturientPurposive { get; set; }
    }
}
