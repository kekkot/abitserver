using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class SpecialtyDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int BudgetPlaces { get; set; }
        public int CommercialPlaces { get; set; }
        public string SpecialtyCode { get; set; }

        public virtual Specialty SpecialtyCodeNavigation { get; set; }
    }
}
