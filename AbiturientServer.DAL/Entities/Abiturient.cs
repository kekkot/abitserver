using System;
using System.Collections.Generic;

#nullable disable

namespace AbiturientServer.DAL.Entities
{
    public partial class Abiturient
    {
        public Abiturient()
        {
            AbiturientExams = new HashSet<AbiturientExam>();
            AbiturientIndividualAchievements = new HashSet<AbiturientIndividualAchievement>();
            Applications = new HashSet<Application>();
            DocumentPhotos = new HashSet<DocumentPhoto>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public int? AbiturientNoExamsId { get; set; }
        public int? AbiturientPrivilegeId { get; set; }
        public int AbiturientEducationId { get; set; }
        public int AbiturientVerificationDocumentId { get; set; }
        public int? AbiturientPurposiveId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public int LanguageId { get; set; }
        public bool NeedHostel { get; set; }
        public string InsuranceNumber { get; set; }
        public int? ParentId { get; set; }
        public string AddedUserId { get; set; }
        public DateTime Added { get; set; }
        public string UpdatedUserId { get; set; }
        public DateTime Updated { get; set; }
        public bool Locked { get; set; }
        public bool Checked { get; set; }

        public virtual AbiturientEducation AbiturientEducation { get; set; }
        public virtual AbiturientNoExam AbiturientNoExams { get; set; }
        public virtual AbiturientPrivilege AbiturientPrivilege { get; set; }
        public virtual AbiturientPurposive AbiturientPurposive { get; set; }
        public virtual AbiturientVerificationDocument AbiturientVerificationDocument { get; set; }
        public virtual User AddedUser { get; set; }
        public virtual Address Address { get; set; }
        public virtual Language Language { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual User UpdatedUser { get; set; }
        public virtual ICollection<AbiturientExam> AbiturientExams { get; set; }
        public virtual ICollection<AbiturientIndividualAchievement> AbiturientIndividualAchievements { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<DocumentPhoto> DocumentPhotos { get; set; }
    }
}
