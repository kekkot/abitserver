﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.PL.API.JsonModels
{
    public class Exam
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public List<int> ExamFormIds { get; set; }

        public Exam()
        {
            ExamFormIds = new List<int>();
        }
    }
}
