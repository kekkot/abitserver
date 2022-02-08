using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class DocumentAchievement
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public bool Checked { get; set; }
        public int? AbiturientIndividualAchievementId { get; set; }

        public virtual AbiturientIndividualAchievement AbiturientIndividualAchievement { get; set; }
    }
}
