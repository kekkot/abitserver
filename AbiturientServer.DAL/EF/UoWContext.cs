using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbiturientServer.DAL.Interfaces;
using AbiturientServer.DAL.Repositories;

namespace AbiturientServer.DAL.EF
{
    public class UoWContext : IUnitOfWork
    {
        private DatabaseContext db;
        public AbiturientEducationRepository AbiturientEducations { get; private set; }
        public AbiturientExamRepository AbiturientExams { get; private set; }
        public AbiturientIndividualAchievementRepository AbiturientIndividualAchievements { get; private set; }
        public AbiturientNoExamRepository AbiturientNoExams { get; private set; }
        public AbiturientPrivilegeRepository AbiturientPrivileges { get; private set; }
        public AbiturientPurposiveRepository AbiturientPurposives { get; private set; }
        public AbiturientRepository Abiturients { get; private set; }
        public AbiturientVerificationDocumentRepository AbiturientVerificationDocuments { get; private set; }
        public AddressRepository Addresses { get; private set; }
        public ApplicationAbiturientExamRepository ApplicationAbiturientExams { get; private set; }
        public ApplicationRepository Applications { get; private set; }
        public ContestRepository Contests { get; private set; }
        public CountryRepository Countries { get; private set; }
        public DepartmentRepository Departments { get; private set; }
        public DocumentAchievementRepository DocumentAchievements { get; private set; }
        public DocumentApprovalRepository DocumentApprovals { get; private set; }
        public DocumentEducationRepository DocumentEducations { get; private set; }
        public DocumentExamGradeRepository DocumentExamGrades { get; private set; }
        public DocumentNoExamRepository DocumentNoExams { get; private set; }
        public DocumentPersonalRepository DocumentPersonals { get; private set; }
        public DocumentPhotoRepository DocumentPhotos { get; private set; }
        public DocumentPrivilegeRepository DocumentPrivileges { get; private set; }
        public DocumentPurposiveRepository DocumentPurposives { get; private set; }
        public EducationalDocumentRepository EducationalDocuments { get; private set; }
        public EducationalInstitutionRepository EducationalInstitutions { get; private set; }
        public EducationLevelRepository EducationLevels { get; private set; }
        public EnrollRepository Enrolls { get; private set; }
        public ExamExamFormRepository ExamExamForms { get; private set; }
        public ExamFormRepository ExamForms { get; private set; }
        public ExamGroundRepository ExamGrounds { get; private set; }
        public ExamRepository Exams { get; private set; }
        public FormOfEducationRepository FormOfEducations { get; private set; }
        public IndividualAchievementRepository IndividualAchievements { get; private set; }
        public LanguageRepository Languages { get; private set; }
        public NoExamRepository NoExams { get; private set; }
        public ParentRepository Parents { get; private set; }
        public PrivilegeRepository Privileges { get; private set; }
        public RegionRepository Regions { get; private set; }
        public SpecialtyContestRepository SpecialtyContests { get; private set; }
        public SpecialtyDetailRepository SpecialtyDetails { get; private set; }
        public SpecialtyExamRepository SpecialtyExams { get; private set; }
        public SpecialtyFormOfEducationRepository SpecialtyFormOfEducations { get; private set; }
        public SpecialtyRepository Specialties { get; private set; }
        public StatusRepository Statuses { get; private set; }
        public UserRepository Users { get; private set; }
        public VerificationDocumentRepository VerificationDocuments { get; private set; }


        public UoWContext(DatabaseContext db)
        {
            this.db = db;
            AbiturientEducations = new AbiturientEducationRepository(db);
            AbiturientExams = new AbiturientExamRepository(db);
            AbiturientIndividualAchievements = new AbiturientIndividualAchievementRepository(db);
            AbiturientNoExams = new AbiturientNoExamRepository(db);
            AbiturientPrivileges = new AbiturientPrivilegeRepository(db);
            AbiturientPurposives = new AbiturientPurposiveRepository(db);
            Abiturients = new AbiturientRepository(db);
            AbiturientVerificationDocuments = new AbiturientVerificationDocumentRepository(db);
            Addresses = new AddressRepository(db);
            ApplicationAbiturientExams = new ApplicationAbiturientExamRepository(db);
            Applications = new ApplicationRepository(db);
            Contests = new ContestRepository(db);
            Countries = new CountryRepository(db);
            Departments = new DepartmentRepository(db);
            DocumentAchievements = new DocumentAchievementRepository(db);
            DocumentApprovals = new DocumentApprovalRepository(db);
            DocumentEducations = new DocumentEducationRepository(db);
            DocumentExamGrades = new DocumentExamGradeRepository(db);
            DocumentNoExams = new DocumentNoExamRepository(db);
            DocumentPersonals = new DocumentPersonalRepository(db);
            DocumentPhotos = new DocumentPhotoRepository(db);
            DocumentPrivileges = new DocumentPrivilegeRepository(db);
            DocumentPurposives = new DocumentPurposiveRepository(db);
            EducationalDocuments = new EducationalDocumentRepository(db);
            EducationalInstitutions = new EducationalInstitutionRepository(db);
            EducationLevels = new EducationLevelRepository(db);
            Enrolls = new EnrollRepository(db);
            ExamExamForms = new ExamExamFormRepository(db);
            ExamForms = new ExamFormRepository(db);
            ExamGrounds = new ExamGroundRepository(db);
            Exams = new ExamRepository(db);
            FormOfEducations = new FormOfEducationRepository(db);
            IndividualAchievements = new IndividualAchievementRepository(db);
            Languages = new LanguageRepository(db);
            NoExams = new NoExamRepository(db);
            Parents = new ParentRepository(db);
            Privileges = new PrivilegeRepository(db);
            Regions = new RegionRepository(db);
            SpecialtyContests = new SpecialtyContestRepository(db);
            SpecialtyDetails = new SpecialtyDetailRepository(db);
            SpecialtyExams = new SpecialtyExamRepository(db);
            SpecialtyFormOfEducations = new SpecialtyFormOfEducationRepository(db);
            Specialties = new SpecialtyRepository(db);
            Statuses = new StatusRepository(db);
            Users = new UserRepository(db);
            VerificationDocuments = new VerificationDocumentRepository(db);
        }


        public async Task SaveChangesAsync()
        {
            await db.SaveChangesAsync();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
