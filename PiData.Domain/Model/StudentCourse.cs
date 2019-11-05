﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiData.Domain.Model;

namespace PiData.Domain.Model
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int MidTermPoint { get; set; }
        public int FinalPoint { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
