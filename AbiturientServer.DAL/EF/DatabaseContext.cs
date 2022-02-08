using System;
using AbiturientServer.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AbiturientServer.DAL.EF
{
    public partial class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abiturient> Abiturients { get; set; }
        public virtual DbSet<AbiturientEducation> AbiturientEducations { get; set; }
        public virtual DbSet<AbiturientExam> AbiturientExams { get; set; }
        public virtual DbSet<AbiturientIndividualAchievement> AbiturientIndividualAchievements { get; set; }
        public virtual DbSet<AbiturientNoExam> AbiturientNoExams { get; set; }
        public virtual DbSet<AbiturientPrivilege> AbiturientPrivileges { get; set; }
        public virtual DbSet<AbiturientPurposive> AbiturientPurposives { get; set; }
        public virtual DbSet<AbiturientVerificationDocument> AbiturientVerificationDocuments { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationAbiturientExam> ApplicationAbiturientExams { get; set; }
        public virtual DbSet<Contest> Contests { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DocumentAchievement> DocumentAchievements { get; set; }
        public virtual DbSet<DocumentApproval> DocumentApprovals { get; set; }
        public virtual DbSet<DocumentEducation> DocumentEducations { get; set; }
        public virtual DbSet<DocumentExamGrade> DocumentExamGrades { get; set; }
        public virtual DbSet<DocumentNoExam> DocumentNoExams { get; set; }
        public virtual DbSet<DocumentPersonal> DocumentPersonals { get; set; }
        public virtual DbSet<DocumentPhoto> DocumentPhotos { get; set; }
        public virtual DbSet<DocumentPrivilege> DocumentPrivileges { get; set; }
        public virtual DbSet<DocumentPurposive> DocumentPurposives { get; set; }
        public virtual DbSet<EducationLevel> EducationLevels { get; set; }
        public virtual DbSet<EducationalDocument> EducationalDocuments { get; set; }
        public virtual DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public virtual DbSet<Enroll> Enrolls { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamExamForm> ExamExamForms { get; set; }
        public virtual DbSet<ExamForm> ExamForms { get; set; }
        public virtual DbSet<ExamGround> ExamGrounds { get; set; }
        public virtual DbSet<FormOfEducation> FormOfEducations { get; set; }
        public virtual DbSet<IndividualAchievement> IndividualAchievements { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<NoExam> NoExams { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<SpecialtyContest> SpecialtyContests { get; set; }
        public virtual DbSet<SpecialtyDetail> SpecialtyDetails { get; set; }
        public virtual DbSet<SpecialtyExam> SpecialtyExams { get; set; }
        public virtual DbSet<SpecialtyFormOfEducation> SpecialtyFormOfEducations { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<VerificationDocument> VerificationDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Abiturient>(entity =>
            {
                entity.ToTable("abiturient");

                entity.HasIndex(e => e.AbiturientEducationId, "abiturient_abiturient_education_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.AbiturientNoExamsId, "abiturient_abiturient_no_exams_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.AbiturientPrivilegeId, "abiturient_abiturient_privilege_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.AbiturientPurposiveId, "abiturient_abiturient_purposive_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.AbiturientVerificationDocumentId, "abiturient_abiturient_verification_document_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.AddressId, "abiturient_address_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.ParentId, "abiturient_parent_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientEducationId).HasColumnName("abiturient_education_id");

                entity.Property(e => e.AbiturientNoExamsId).HasColumnName("abiturient_no_exams_id");

                entity.Property(e => e.AbiturientPrivilegeId).HasColumnName("abiturient_privilege_id");

                entity.Property(e => e.AbiturientPurposiveId).HasColumnName("abiturient_purposive_id");

                entity.Property(e => e.AbiturientVerificationDocumentId).HasColumnName("abiturient_verification_document_id");

                entity.Property(e => e.Added).HasColumnName("added");

                entity.Property(e => e.AddedUserId)
                    .IsRequired()
                    .HasColumnName("added_user_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("gender");

                entity.Property(e => e.InsuranceNumber)
                    .HasMaxLength(45)
                    .HasColumnName("insurance_number")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.NeedHostel).HasColumnName("need_hostel");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("number");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(45)
                    .HasColumnName("patronymic")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("surname");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UpdatedUserId)
                    .IsRequired()
                    .HasColumnName("updated_user_id");

                entity.HasOne(d => d.AbiturientEducation)
                    .WithOne(p => p.Abiturient)
                    .HasForeignKey<Abiturient>(d => d.AbiturientEducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_abiturient_education_id_fkey");

                entity.HasOne(d => d.AbiturientNoExams)
                    .WithOne(p => p.Abiturient)
                    .HasForeignKey<Abiturient>(d => d.AbiturientNoExamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("abiturient_abiturient_no_exams_id_fkey");

                entity.HasOne(d => d.AbiturientPrivilege)
                    .WithOne(p => p.Abiturient)
                    .HasForeignKey<Abiturient>(d => d.AbiturientPrivilegeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("abiturient_abiturient_privilege_id_fkey");

                entity.HasOne(d => d.AbiturientPurposive)
                    .WithOne(p => p.Abiturient)
                    .HasForeignKey<Abiturient>(d => d.AbiturientPurposiveId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("abiturient_abiturient_purposive_id_fkey");

                entity.HasOne(d => d.AbiturientVerificationDocument)
                    .WithOne(p => p.Abiturient)
                    .HasForeignKey<Abiturient>(d => d.AbiturientVerificationDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_abiturient_verification_document_id_fkey");

                entity.HasOne(d => d.AddedUser)
                    .WithMany(p => p.AbiturientAddedUsers)
                    .HasForeignKey(d => d.AddedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_added_user_id_fkey");

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.Abiturient)
                    .HasForeignKey<Abiturient>(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_address_id_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Abiturients)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_language_id_fkey");

                entity.HasOne(d => d.Parent)
                    .WithOne(p => p.Abiturient)
                    .HasForeignKey<Abiturient>(d => d.ParentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("abiturient_parent_id_fkey");

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.AbiturientUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_updated_user_id_fkey");
            });

            modelBuilder.Entity<AbiturientEducation>(entity =>
            {
                entity.ToTable("abiturient_education");

                entity.HasIndex(e => e.AddressId, "abiturient_education_address_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("address_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.DateOfIssue)
                    .HasColumnType("date")
                    .HasColumnName("date_of_issue");

                entity.Property(e => e.EducationalDocumentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("educational_document_code");

                entity.Property(e => e.EducationalInstitutionCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("educational_institution_code");

                entity.Property(e => e.GivenBy)
                    .HasMaxLength(200)
                    .HasColumnName("given_by")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Number)
                    .HasMaxLength(45)
                    .HasColumnName("number")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Series)
                    .HasMaxLength(45)
                    .HasColumnName("series")
                    .HasDefaultValueSql("NULL::character varying");

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.AbiturientEducation)
                    .HasForeignKey<AbiturientEducation>(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_education_address_id_fkey");

                entity.HasOne(d => d.EducationalDocumentCodeNavigation)
                    .WithMany(p => p.AbiturientEducations)
                    .HasForeignKey(d => d.EducationalDocumentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_education_educational_document_code_fkey");

                entity.HasOne(d => d.EducationalInstitutionCodeNavigation)
                    .WithMany(p => p.AbiturientEducations)
                    .HasForeignKey(d => d.EducationalInstitutionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_education_educational_institution_code_fkey");
            });

            modelBuilder.Entity<AbiturientExam>(entity =>
            {
                entity.ToTable("abiturient_exam");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientId).HasColumnName("abiturient_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.EntranceGroup).HasColumnName("entrance_group");

                entity.Property(e => e.ExamCode).HasColumnName("exam_code");

                entity.Property(e => e.ExamFormId).HasColumnName("exam_form_id");

                entity.Property(e => e.ExamGroundCode)
                    .HasMaxLength(10)
                    .HasColumnName("exam_ground_code")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.LastUpdate).HasColumnName("last_update");

                entity.Property(e => e.Mark).HasColumnName("mark");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Abiturient)
                    .WithMany(p => p.AbiturientExams)
                    .HasForeignKey(d => d.AbiturientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("abiturient_exam_abiturient_id_fkey");

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.AbiturientExams)
                    .HasForeignKey(d => d.ExamCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_exam_exam_code_fkey");

                entity.HasOne(d => d.ExamForm)
                    .WithMany(p => p.AbiturientExams)
                    .HasForeignKey(d => d.ExamFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_exam_exam_form_id_fkey");

                entity.HasOne(d => d.ExamGroundCodeNavigation)
                    .WithMany(p => p.AbiturientExams)
                    .HasForeignKey(d => d.ExamGroundCode)
                    .HasConstraintName("abiturient_exam_exam_ground_code_fkey");
            });

            modelBuilder.Entity<AbiturientIndividualAchievement>(entity =>
            {
                entity.ToTable("abiturient_individual_achievement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientId).HasColumnName("abiturient_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.DateOfIssue)
                    .HasColumnType("date")
                    .HasColumnName("date_of_issue");

                entity.Property(e => e.ExtraInfo)
                    .HasMaxLength(150)
                    .HasColumnName("extra_info")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.IndividualAchievementCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("individual_achievement_code");

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("organization");

                entity.HasOne(d => d.Abiturient)
                    .WithMany(p => p.AbiturientIndividualAchievements)
                    .HasForeignKey(d => d.AbiturientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("abiturient_individual_achievement_abiturient_id_fkey");

                entity.HasOne(d => d.IndividualAchievementCodeNavigation)
                    .WithMany(p => p.AbiturientIndividualAchievements)
                    .HasForeignKey(d => d.IndividualAchievementCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_individual_achievem_individual_achievement_code_fkey");
            });

            modelBuilder.Entity<AbiturientNoExam>(entity =>
            {
                entity.ToTable("abiturient_no_exams");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.DateOfIssue)
                    .HasColumnType("date")
                    .HasColumnName("date_of_issue");

                entity.Property(e => e.GivenBy)
                    .HasMaxLength(200)
                    .HasColumnName("given_by")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.NoExamsCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("no_exams_code");

                entity.Property(e => e.Number)
                    .HasMaxLength(45)
                    .HasColumnName("number")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Series)
                    .HasMaxLength(45)
                    .HasColumnName("series")
                    .HasDefaultValueSql("NULL::character varying");

                entity.HasOne(d => d.NoExamsCodeNavigation)
                    .WithMany(p => p.AbiturientNoExams)
                    .HasForeignKey(d => d.NoExamsCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_no_exams_no_exams_code_fkey");
            });

            modelBuilder.Entity<AbiturientPrivilege>(entity =>
            {
                entity.ToTable("abiturient_privilege");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.DateOfIssue)
                    .HasColumnType("date")
                    .HasColumnName("date_of_issue");

                entity.Property(e => e.GivenBy)
                    .HasMaxLength(200)
                    .HasColumnName("given_by")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Number)
                    .HasMaxLength(45)
                    .HasColumnName("number")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PrivilegeCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("privilege_code");

                entity.Property(e => e.Series)
                    .HasMaxLength(45)
                    .HasColumnName("series")
                    .HasDefaultValueSql("NULL::character varying");

                entity.HasOne(d => d.PrivilegeCodeNavigation)
                    .WithMany(p => p.AbiturientPrivileges)
                    .HasForeignKey(d => d.PrivilegeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_privilege_privilege_code_fkey");
            });

            modelBuilder.Entity<AbiturientPurposive>(entity =>
            {
                entity.ToTable("abiturient_purposive");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("organization_name");
            });

            modelBuilder.Entity<AbiturientVerificationDocument>(entity =>
            {
                entity.ToTable("abiturient_verification_document");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.DateOfIssue)
                    .HasColumnType("date")
                    .HasColumnName("date_of_issue");

                entity.Property(e => e.GivenBy)
                    .HasMaxLength(200)
                    .HasColumnName("given_by")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Number)
                    .HasMaxLength(45)
                    .HasColumnName("number")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Series)
                    .HasMaxLength(45)
                    .HasColumnName("series")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.SubdivisCode)
                    .HasMaxLength(10)
                    .HasColumnName("subdivis_code")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.VerificationDocumentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("verification_document_id");

                entity.HasOne(d => d.VerificationDocument)
                    .WithMany(p => p.AbiturientVerificationDocuments)
                    .HasForeignKey(d => d.VerificationDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("abiturient_verification_document_verification_document_id_fkey");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .HasColumnName("address")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.City)
                    .HasMaxLength(45)
                    .HasColumnName("city")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.RegionCode).HasColumnName("region_code");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("address_country_code_fkey");

                entity.HasOne(d => d.RegionCodeNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.RegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("address_region_code_fkey");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("application");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientId).HasColumnName("abiturient_id");

                entity.Property(e => e.Added).HasColumnName("added");

                entity.Property(e => e.AddedUserId)
                    .IsRequired()
                    .HasColumnName("added_user_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.ContestCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("contest_code");

                entity.Property(e => e.EnrollId).HasColumnName("enroll_id");

                entity.Property(e => e.FormOfEducationCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("form_of_education_code");

                entity.Property(e => e.IsOriginal).HasColumnName("is_original");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("number");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasColumnName("remark")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.SpecialtyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("specialty_code");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Updated).HasColumnName("updated");

                entity.Property(e => e.UpdatedUserId)
                    .IsRequired()
                    .HasColumnName("updated_user_id");

                entity.HasOne(d => d.Abiturient)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.AbiturientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("application_abiturient_id_fkey");

                entity.HasOne(d => d.AddedUser)
                    .WithMany(p => p.ApplicationAddedUsers)
                    .HasForeignKey(d => d.AddedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_added_user_id_fkey");

                entity.HasOne(d => d.ContestCodeNavigation)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.ContestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_contest_code_fkey");

                entity.HasOne(d => d.Enroll)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.EnrollId)
                    .HasConstraintName("application_enroll_id_fkey");

                entity.HasOne(d => d.FormOfEducationCodeNavigation)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.FormOfEducationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_form_of_education_code_fkey");

                entity.HasOne(d => d.SpecialtyCodeNavigation)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.SpecialtyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_specialty_code_fkey");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_status_id_fkey");

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.ApplicationUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_updated_user_id_fkey");
            });

            modelBuilder.Entity<ApplicationAbiturientExam>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationId, e.AbiturientExamId })
                    .HasName("application_abiturient_exam_pkey");

                entity.ToTable("application_abiturient_exam");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.AbiturientExamId).HasColumnName("abiturient_exam_id");

                entity.HasOne(d => d.AbiturientExam)
                    .WithMany(p => p.ApplicationAbiturientExams)
                    .HasForeignKey(d => d.AbiturientExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_abiturient_exam_abiturient_exam_id_fkey");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationAbiturientExams)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("application_abiturient_exam_application_id_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.DepartmentCode, "IX_AspNetUsers_DepartmentCode");

                entity.Property(e => e.DepartmentCode).HasMaxLength(10);

                entity.HasOne(d => d.DepartmentCodeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartmentCode);
            });

            modelBuilder.Entity<Contest>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("contest_pkey");

                entity.ToTable("contest");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("1000");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("country_pkey");

                entity.ToTable("country");

                entity.Property(e => e.Code)
                    .ValueGeneratedNever()
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("1000");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("department");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<DocumentAchievement>(entity =>
            {
                entity.ToTable("document_achievement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientIndividualAchievementId).HasColumnName("abiturient_individual_achievement_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.AbiturientIndividualAchievement)
                    .WithMany(p => p.DocumentAchievements)
                    .HasForeignKey(d => d.AbiturientIndividualAchievementId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_achievement_abiturient_individual_achievement_id_fkey");
            });

            modelBuilder.Entity<DocumentApproval>(entity =>
            {
                entity.ToTable("document_approval");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.DocumentApprovals)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_approval_application_id_fkey");
            });

            modelBuilder.Entity<DocumentEducation>(entity =>
            {
                entity.ToTable("document_education");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientEducationId).HasColumnName("abiturient_education_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.AbiturientEducation)
                    .WithMany(p => p.DocumentEducations)
                    .HasForeignKey(d => d.AbiturientEducationId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_education_abiturient_education_id_fkey");
            });

            modelBuilder.Entity<DocumentExamGrade>(entity =>
            {
                entity.ToTable("document_exam_grade");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientExamId).HasColumnName("abiturient_exam_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.AbiturientExam)
                    .WithMany(p => p.DocumentExamGrades)
                    .HasForeignKey(d => d.AbiturientExamId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_exam_grade_abiturient_exam_id_fkey");
            });

            modelBuilder.Entity<DocumentNoExam>(entity =>
            {
                entity.ToTable("document_no_exam");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientNoExamsId).HasColumnName("abiturient_no_exams_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.AbiturientNoExams)
                    .WithMany(p => p.DocumentNoExams)
                    .HasForeignKey(d => d.AbiturientNoExamsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_no_exam_abiturient_no_exams_id_fkey");
            });

            modelBuilder.Entity<DocumentPersonal>(entity =>
            {
                entity.ToTable("document_personal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientVerificationDocumentId).HasColumnName("abiturient_verification_document_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.AbiturientVerificationDocument)
                    .WithMany(p => p.DocumentPersonals)
                    .HasForeignKey(d => d.AbiturientVerificationDocumentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_personal_abiturient_verification_document_id_fkey");
            });

            modelBuilder.Entity<DocumentPhoto>(entity =>
            {
                entity.ToTable("document_photo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientId).HasColumnName("abiturient_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.Abiturient)
                    .WithMany(p => p.DocumentPhotos)
                    .HasForeignKey(d => d.AbiturientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_photo_abiturient_id_fkey");
            });

            modelBuilder.Entity<DocumentPrivilege>(entity =>
            {
                entity.ToTable("document_privilege");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientPrivilegeId).HasColumnName("abiturient_privilege_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.AbiturientPrivilege)
                    .WithMany(p => p.DocumentPrivileges)
                    .HasForeignKey(d => d.AbiturientPrivilegeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_privilege_abiturient_privilege_id_fkey");
            });

            modelBuilder.Entity<DocumentPurposive>(entity =>
            {
                entity.ToTable("document_purposive");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbiturientPurposiveId).HasColumnName("abiturient_purposive_id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("uri");

                entity.HasOne(d => d.AbiturientPurposive)
                    .WithMany(p => p.DocumentPurposives)
                    .HasForeignKey(d => d.AbiturientPurposiveId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("document_purposive_abiturient_purposive_id_fkey");
            });

            modelBuilder.Entity<EducationLevel>(entity =>
            {
                entity.ToTable("education_level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<EducationalDocument>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("educational_document_pkey");

                entity.ToTable("educational_document");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<EducationalInstitution>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("educational_institution_pkey");

                entity.ToTable("educational_institution");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Enroll>(entity =>
            {
                entity.ToTable("enroll");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(45)
                    .HasColumnName("code")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.ContestCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("contest_code");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("department_code");

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .HasColumnName("description")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Level)
                    .HasMaxLength(45)
                    .HasColumnName("level")
                    .HasDefaultValueSql("NULL::character varying");

                entity.HasOne(d => d.ContestCodeNavigation)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.ContestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enroll_contest_code_fkey");

                entity.HasOne(d => d.DepartmentCodeNavigation)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.DepartmentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enroll_department_code_fkey");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("exam_pkey");

                entity.ToTable("exam");

                entity.Property(e => e.Code)
                    .ValueGeneratedNever()
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ExamExamForm>(entity =>
            {
                entity.HasKey(e => new { e.ExamFormId, e.ExamCode })
                    .HasName("exam_exam_form_pkey");

                entity.ToTable("exam_exam_form");

                entity.Property(e => e.ExamFormId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("exam_form_id");

                entity.Property(e => e.ExamCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("exam_code");

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.ExamExamForms)
                    .HasForeignKey(d => d.ExamCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exam_exam_form_exam_code_fkey");

                entity.HasOne(d => d.ExamForm)
                    .WithMany(p => p.ExamExamForms)
                    .HasForeignKey(d => d.ExamFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exam_exam_form_exam_form_id_fkey");
            });

            modelBuilder.Entity<ExamForm>(entity =>
            {
                entity.ToTable("exam_form");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ExamGround>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("exam_ground_pkey");

                entity.ToTable("exam_ground");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            modelBuilder.Entity<FormOfEducation>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("form_of_education_pkey");

                entity.ToTable("form_of_education");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("1000");
            });

            modelBuilder.Entity<IndividualAchievement>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("individual_achievement_pkey");

                entity.ToTable("individual_achievement");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.AdditionalScore).HasColumnName("additional_score");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("1000");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("language");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .HasColumnName("code")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NoExam>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("no_exams_pkey");

                entity.ToTable("no_exams");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("parent");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(45)
                    .HasColumnName("patronymic")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("privilege_pkey");

                entity.ToTable("privilege");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("1000");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("region_pkey");

                entity.ToTable("region");

                entity.Property(e => e.Code)
                    .ValueGeneratedNever()
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("1000");
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("specialty_pkey");

                entity.ToTable("specialty");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("department_code");

                entity.Property(e => e.EducationLevelId).HasColumnName("education_level_id");

                entity.HasOne(d => d.DepartmentCodeNavigation)
                    .WithMany(p => p.Specialties)
                    .HasForeignKey(d => d.DepartmentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_department_code_fkey");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.Specialties)
                    .HasForeignKey(d => d.EducationLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_education_level_fk_id");
            });

            modelBuilder.Entity<SpecialtyContest>(entity =>
            {
                entity.HasKey(e => new { e.SpecialtyCode, e.ContestCode })
                    .HasName("specialty_contest_pkey");

                entity.ToTable("specialty_contest");

                entity.Property(e => e.SpecialtyCode)
                    .HasMaxLength(10)
                    .HasColumnName("specialty_code");

                entity.Property(e => e.ContestCode)
                    .HasMaxLength(5)
                    .HasColumnName("contest_code");

                entity.HasOne(d => d.ContestCodeNavigation)
                    .WithMany(p => p.SpecialtyContests)
                    .HasForeignKey(d => d.ContestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_contest_contest_code_fkey");

                entity.HasOne(d => d.SpecialtyCodeNavigation)
                    .WithMany(p => p.SpecialtyContests)
                    .HasForeignKey(d => d.SpecialtyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_contest_specialty_code_fkey");
            });

            modelBuilder.Entity<SpecialtyDetail>(entity =>
            {
                entity.ToTable("specialty_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BudgetPlaces).HasColumnName("budget_places");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .HasColumnName("code")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CommercialPlaces).HasColumnName("commercial_places");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.SpecialtyCode)
                    .HasMaxLength(10)
                    .HasColumnName("specialty_code");

                entity.HasOne(d => d.SpecialtyCodeNavigation)
                    .WithMany(p => p.SpecialtyDetails)
                    .HasForeignKey(d => d.SpecialtyCode)
                    .HasConstraintName("specialty_details_specialty_code_fkey");
            });

            modelBuilder.Entity<SpecialtyExam>(entity =>
            {
                entity.HasKey(e => new { e.SpecialtyCode, e.ExamCode })
                    .HasName("specialty_exam_pkey");

                entity.ToTable("specialty_exam");

                entity.Property(e => e.SpecialtyCode)
                    .HasMaxLength(10)
                    .HasColumnName("specialty_code");

                entity.Property(e => e.ExamCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("exam_code");

                entity.Property(e => e.MinimalScore).HasColumnName("minimal_score");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.SpecialtyExams)
                    .HasForeignKey(d => d.ExamCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_exam_exam_code_fkey");

                entity.HasOne(d => d.SpecialtyCodeNavigation)
                    .WithMany(p => p.SpecialtyExams)
                    .HasForeignKey(d => d.SpecialtyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_exam_specialty_code_fkey");
            });

            modelBuilder.Entity<SpecialtyFormOfEducation>(entity =>
            {
                entity.HasKey(e => new { e.SpecialtyCode, e.FormOfEducationCode })
                    .HasName("specialty_form_of_education_pkey");

                entity.ToTable("specialty_form_of_education");

                entity.Property(e => e.SpecialtyCode)
                    .HasMaxLength(10)
                    .HasColumnName("specialty_code");

                entity.Property(e => e.FormOfEducationCode)
                    .HasMaxLength(5)
                    .HasColumnName("form_of_education_code");

                entity.HasOne(d => d.FormOfEducationCodeNavigation)
                    .WithMany(p => p.SpecialtyFormOfEducations)
                    .HasForeignKey(d => d.FormOfEducationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_form_of_education_form_of_education_code_fkey");

                entity.HasOne(d => d.SpecialtyCodeNavigation)
                    .WithMany(p => p.SpecialtyFormOfEducations)
                    .HasForeignKey(d => d.SpecialtyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("specialty_form_of_education_specialty_code_fkey");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<VerificationDocument>(entity =>
            {
                entity.ToTable("verification_document");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasDefaultValueSql("1000");
            });

            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
