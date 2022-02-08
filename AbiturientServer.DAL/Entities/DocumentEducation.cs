using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class DocumentEducation
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool Checked { get; set; }
        public int? AbiturientEducationId { get; set; }

        public virtual AbiturientEducation AbiturientEducation { get; set; }
    }
}
