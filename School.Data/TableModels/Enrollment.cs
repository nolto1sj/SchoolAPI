﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.TableModels
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
