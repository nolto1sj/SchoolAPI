using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.TableModels
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Teacher { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
