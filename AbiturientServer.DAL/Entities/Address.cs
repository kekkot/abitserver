using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Address
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public int RegionCode { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual Region RegionCodeNavigation { get; set; }
        public virtual Abiturient Abiturient { get; set; }
        public virtual AbiturientEducation AbiturientEducation { get; set; }
    }
}
