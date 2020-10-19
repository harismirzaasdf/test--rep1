using StudentApiApplication.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentApiApplication.Controllers
{
    public class StudentsController : ApiController
    {
        static readonly IStudentRepository studentRepository = new StudentRepository();

        public IEnumerable<Student> GetAll()
        {
            return studentRepository.GetAllStudents();
        }
    }
}