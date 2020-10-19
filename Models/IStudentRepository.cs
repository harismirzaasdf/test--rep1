using System;
using System.Collections.Generic;

namespace StudentApiApplication.Models
{
    interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student AddStudent(Student Student);
    }
}