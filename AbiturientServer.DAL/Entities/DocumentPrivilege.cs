using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class DocumentPrivilege
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool Checked { get; set; }
        public int? AbiturientPrivilegeId { get; set; }

        public virtual AbiturientPrivilege AbiturientPrivilege { get; set; }
    }
}
