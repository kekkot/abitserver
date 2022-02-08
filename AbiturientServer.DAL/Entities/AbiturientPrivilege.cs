using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class AbiturientPrivilege
    {
        public AbiturientPrivilege()
        {
            DocumentPrivileges = new HashSet<DocumentPrivilege>();
        }

        public int Id { get; set; }
        public string PrivilegeCode { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string GivenBy { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public bool Checked { get; set; }

        public virtual Privilege PrivilegeCodeNavigation { get; set; }
        public virtual Abiturient Abiturient { get; set; }
        public virtual ICollection<DocumentPrivilege> DocumentPrivileges { get; set; }
    }
}
