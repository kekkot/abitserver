using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Privilege
    {
        public Privilege()
        {
            AbiturientPrivileges = new HashSet<AbiturientPrivilege>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public float? Order { get; set; }

        public virtual ICollection<AbiturientPrivilege> AbiturientPrivileges { get; set; }
    }
}
