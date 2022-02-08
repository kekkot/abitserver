using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Region
    {
        public Region()
        {
            Addresses = new HashSet<Address>();
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public float? Order { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
