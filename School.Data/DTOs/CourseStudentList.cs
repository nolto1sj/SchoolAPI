using School.Data.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.DTOs
{
    public class CourseStudentList
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseTeacher { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
