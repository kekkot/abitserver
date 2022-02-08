using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Language
    {
        public Language()
        {
            Abiturients = new HashSet<Abiturient>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Abiturient> Abiturients { get; set; }
    }
}
