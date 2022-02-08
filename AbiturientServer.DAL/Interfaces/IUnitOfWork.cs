using AbiturientServer.DAL.Entities;
using AbiturientServer.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        AbiturientEducationRepository AbiturientEducations { get; }
        AbiturientExamRepository AbiturientExams { get; }
        AbiturientIndividualAchievementRepository AbiturientIndividualAchievements { get; }
        AbiturientNoExamRepository AbiturientNoExams { get; }
        AbiturientPrivilegeRepository AbiturientPrivileges { get; }
        AbiturientPurposiveRepository AbiturientPurposives { get; }
        AbiturientRepository Abiturients { get; }
        AbiturientVerificationDocumentRepository AbiturientVerificationDocuments { get; }
        AddressRepository Addresses { get; }
        ApplicationAbiturientExamRepository ApplicationAbiturientExams { get; }
        ApplicationRepository Applications { get; }
        ContestRepository Contests { get; }
        CountryRepository Countries { get; }
        DepartmentRepository Departments { get; }
        DocumentAchievementRepository DocumentAchievements { get; }
        DocumentApprovalRepository DocumentApprovals { get; }
        DocumentEducationRepository DocumentEducations { get; }
        DocumentExamGradeRepository DocumentExamGrades { get; }
        DocumentNoExamRepository DocumentNoExams { get; }
        DocumentPersonalRepository DocumentPersonals { get; }
        DocumentPhotoRepository DocumentPhotos { get; }
        DocumentPrivilegeRepository DocumentPrivileges { get; }
        DocumentPurposiveRepository DocumentPurposives { get; }
        EducationalDocumentRepository EducationalDocuments { get; }
        EducationalInstitutionRepository EducationalInstitutions { get; }
        EducationLevelRepository EducationLevels { get; }
        EnrollRepository Enrolls { get; }
        ExamExamFormRepository ExamExamForms { get; }
        ExamFormRepository ExamForms { get; }
        ExamGroundRepository ExamGrounds { get; }
        ExamRepository Exams { get; }
        FormOfEducationRepository FormOfEducations { get; }
        IndividualAchievementRepository IndividualAchievements { get; }
        LanguageRepository Languages { get; }
        NoExamRepository NoExams { get; }
        ParentRepository Parents { get; }
        PrivilegeRepository Privileges { get; }
        RegionRepository Regions { get; }
        SpecialtyContestRepository SpecialtyContests { get; }
        SpecialtyDetailRepository SpecialtyDetails { get; }
        SpecialtyExamRepository SpecialtyExams { get; }
        SpecialtyFormOfEducationRepository SpecialtyFormOfEducations { get; }
        SpecialtyRepository Specialties { get; }
        StatusRepository Statuses { get; }
        UserRepository Users { get; }
        VerificationDocumentRepository VerificationDocuments { get; }
        Task SaveChangesAsync();
    }
}
