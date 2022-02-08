using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class AbiturientPurposive
    {
        public AbiturientPurposive()
        {
            DocumentPurposives = new HashSet<DocumentPurposive>();
        }

        public int Id { get; set; }
        public string OrganizationName { get; set; }
        public bool Checked { get; set; }

        public virtual Abiturient Abiturient { get; set; }
        public virtual ICollection<DocumentPurposive> DocumentPurposives { get; set; }
    }
}
