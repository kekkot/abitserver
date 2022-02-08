using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;
using AbiturientServer.DAL.Interfaces;
using AbiturientServer.PL.API.JsonModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AbiturientServer.PL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class EnvironmentController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        public EnvironmentController(IUnitOfWork context)
        {
            _context = context;
        }

        [HttpGet("IsCampaignFormed")]
        public async Task<IActionResult> IsCampaignFormed()
        {
            if((await _context.Departments.GetAll().ToListAsync()).Count != 0 &&
                (await _context.Exams.GetAll().ToListAsync()).Count != 0 &&
                (await _context.Specialties.GetAll().ToListAsync()).Count != 0)
            {
                return Ok(true);
            }
            return Ok(false);
        }


        [HttpGet("ExamForm")]
        public async Task<IActionResult> ExamForm()
        {
            List<ExamForm> ExamForms = await _context.ExamForms.GetAll().OrderBy(e => e.Id).ToListAsync();
            return Ok(ExamForms);
        }

        [HttpGet("Contest")]
        public async Task<IActionResult> Contest()
        {
            List<Contest> Contests = await _context.Contests.GetAll().OrderBy(e => e.Order).ToListAsync();
            return Ok(Contests);
        }

        [HttpGet("EducationLevel")]
        public async Task<IActionResult> EducationLevel()
        {
            List<EducationLevel> EducationLevels = await _context.EducationLevels.GetAll().OrderBy(e => e.Id).ToListAsync();
            return Ok(EducationLevels);
        }

        [HttpGet("FormOfEducation")]
        public async Task<IActionResult> FormOfEducation()
        {
            List<FormOfEducation> FormOfEducations = await _context.FormOfEducations.GetAll().OrderBy(e => e.Order).ToListAsync();
            return Ok(FormOfEducations);
        }

        [HttpPost("InitCampaign")]
        public async Task<IActionResult> InitCampaign()
        {
            string clientCampaign;
            using (var reader = new StreamReader(Request.Body))
            {
                clientCampaign = await reader.ReadToEndAsync();
            }

            InitCampaignContainer initCompainContainer = JsonConvert.DeserializeObject<InitCampaignContainer>(clientCampaign);
            try
            {
                List<DAL.Entities.Department> departments = ConvertDepartmentList(initCompainContainer.Departments);
                List<DAL.Entities.Exam> exams = ConvertExamList(initCompainContainer.Exams);
                List<DAL.Entities.Specialty> specialties = ConvertSpecialtyList(initCompainContainer.Specialties);

                await _context.Departments.AddRangeAsync(departments);
                await _context.Exams.AddRangeAsync(exams);
                await _context.Specialties.AddRangeAsync(specialties);

                await _context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest("Произошла ошибка");
            }
            return Ok("Кампания сформирована");
        }

        private List<DAL.Entities.Department> ConvertDepartmentList(List<JsonModels.Department> convertDepartments)
        {
            List<DAL.Entities.Department> departments = new List<DAL.Entities.Department>();
            for (int i = 0; i < convertDepartments.Count; i++)
            {
                departments.Add(ConvertDepartment(convertDepartments[i]));
            }
            return departments;
        }
        private List<DAL.Entities.Exam> ConvertExamList(List<JsonModels.Exam> convertExams)
        {
            List<DAL.Entities.Exam> exams = new List<DAL.Entities.Exam>();
            for (int i = 0; i < convertExams.Count; i++)
            {
                exams.Add(ConvertExam(convertExams[i]));
            }
            return exams;
        }
        private List<DAL.Entities.Specialty> ConvertSpecialtyList(List<JsonModels.Specialty> convertSpecialtys)
        {
            List<DAL.Entities.Specialty> specialties = new List<DAL.Entities.Specialty>();
            for (int i = 0; i < convertSpecialtys.Count; i++)
            {
                specialties.Add(ConvertSpecialty(convertSpecialtys[i]));
            }
            return specialties;
        }

        private DAL.Entities.Department ConvertDepartment(JsonModels.Department clientDepartment)
        {
            DAL.Entities.Department serverDepartment = new DAL.Entities.Department();
            serverDepartment.Code = clientDepartment.Code;
            serverDepartment.Name = clientDepartment.Name;
            serverDepartment.Order = clientDepartment.Order;
            return serverDepartment;
        }

        private DAL.Entities.Exam ConvertExam(JsonModels.Exam clientExams)
        {
            DAL.Entities.Exam serverExam = new DAL.Entities.Exam();
            for (int i = 0; i < clientExams.ExamFormIds.Count; i++)
            {
                ExamExamForm examExamForm = new ExamExamForm();
                examExamForm.ExamCode = clientExams.Code;
                examExamForm.ExamFormId = clientExams.ExamFormIds[i];
                serverExam.ExamExamForms.Add(examExamForm);
            }

            serverExam.Name = clientExams.Name;
            serverExam.Code = clientExams.Code;
            return serverExam;
        }

        private DAL.Entities.Specialty ConvertSpecialty(JsonModels.Specialty clientSpecilaty)
        {
            DAL.Entities.Specialty serverSpecialty = new DAL.Entities.Specialty();
            for (int i = 0; i < clientSpecilaty.SpecialtyContestCodes.Count; i++)
            {
                SpecialtyContest specialtyContest = new SpecialtyContest();
                specialtyContest.ContestCode = clientSpecilaty.SpecialtyContestCodes[i];
                specialtyContest.SpecialtyCode = clientSpecilaty.Code;
                serverSpecialty.SpecialtyContests.Add(specialtyContest);
            }

            for (int j = 0; j < clientSpecilaty.SpecialtyFormOfEducationCodes.Count; j++)
            {
                SpecialtyFormOfEducation specialtyFormOfEducation = new SpecialtyFormOfEducation();
                specialtyFormOfEducation.FormOfEducationCode = clientSpecilaty.SpecialtyFormOfEducationCodes[j];
                specialtyFormOfEducation.SpecialtyCode = clientSpecilaty.Code;
                serverSpecialty.SpecialtyFormOfEducations.Add(specialtyFormOfEducation);
            }

            for (int j = 0; j < clientSpecilaty.SpecialtyExams.Count; j++)
            {
                DAL.Entities.SpecialtyExam specialtyExam = new DAL.Entities.SpecialtyExam();
                specialtyExam.SpecialtyCode = clientSpecilaty.Code;
                specialtyExam.ExamCode = clientSpecilaty.SpecialtyExams[j].ExamCode;
                specialtyExam.MinimalScore = clientSpecilaty.SpecialtyExams[j].MinimalScore;
                specialtyExam.Priority = clientSpecilaty.SpecialtyExams[j].Priority;
                serverSpecialty.SpecialtyExams.Add(specialtyExam);
            }
            SpecialtyDetail specialtyDetail = new SpecialtyDetail();
            specialtyDetail.Name = clientSpecilaty.Name;
            specialtyDetail.SpecialtyCode = clientSpecilaty.Code;
            specialtyDetail.Code = clientSpecilaty.Cypher;
            specialtyDetail.BudgetPlaces = clientSpecilaty.BudgetPlaces;
            specialtyDetail.CommercialPlaces = clientSpecilaty.CommercialPlaces;
            serverSpecialty.SpecialtyDetails.Add(specialtyDetail);

            serverSpecialty.Code = clientSpecilaty.Code;
            serverSpecialty.DepartmentCode = clientSpecilaty.DepartmentCode;
            serverSpecialty.EducationLevelId = clientSpecilaty.EducationLevelId;
            return serverSpecialty;
        }
    }
}
