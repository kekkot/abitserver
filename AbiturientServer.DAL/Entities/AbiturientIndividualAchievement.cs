using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class AbiturientIndividualAchievement
    {
        public AbiturientIndividualAchievement()
        {
            DocumentAchievements = new HashSet<DocumentAchievement>();
        }

        public int Id { get; set; }
        public string Organization { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string ExtraInfo { get; set; }
        public int AbiturientId { get; set; }
        public string IndividualAchievementCode { get; set; }
        public bool Checked { get; set; }

        public virtual Abiturient Abiturient { get; set; }
        public virtual IndividualAchievement IndividualAchievementCodeNavigation { get; set; }
        public virtual ICollection<DocumentAchievement> DocumentAchievements { get; set; }
    }
}
