using AbiturientServer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbiturientServer.PL.API.JsonModels
{
    public class InitCompaign
    {
        public List<EducationLevel> EducationLevels { get; set; }
        public List<Contest> Contests { get; set; }
        public List<FormOfEducation> FormOfEducations { get; set; }
        public List<ExamForm> ExamForms { get; set; }
    }
}
