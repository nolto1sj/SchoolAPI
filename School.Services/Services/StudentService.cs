using School.Data;
using School.Data.DTOs;
using School.Data.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace School.Services.Services
{
    public interface IStudentService
    {
        Student CreateStudent(string name);
        Task<Student> CreateRandomStudent();
        ICollection<Student> GetStudents();
        Student GetStudent(int id);
        Student UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly SchoolDbContext _context;
        private readonly HttpClient _client;

        public StudentService(SchoolDbContext context, HttpClient client)
        {
            _context = context;
            _client = client;
        }

        public Student CreateStudent(string name)
        {
            var student = new Student()
            {
                Name = name
            };

            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public async Task<Student> CreateRandomStudent()
        {
            var nameFakePerson = await _client.GetFromJsonAsync<NameFakePerson>("https://api.namefake.com/");

            var student = new Student()
            {
                Name = nameFakePerson.Name
            };

            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        public ICollection<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
