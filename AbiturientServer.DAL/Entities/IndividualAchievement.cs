using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class IndividualAchievement
    {
        public IndividualAchievement()
        {
            AbiturientIndividualAchievements = new HashSet<AbiturientIndividualAchievement>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int AdditionalScore { get; set; }
        public float? Order { get; set; }

        public virtual ICollection<AbiturientIndividualAchievement> AbiturientIndividualAchievements { get; set; }
    }
}
