using System;
using System.Collections.Generic;

namespace StudentApiApplication.Models
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> items = new List<Student>();
        private int next = 1;
        public StudentRepository()
        {
            AddStudent(new Student { ID = 1, Name = "Rizwan", City = "Dina", Course = "B.Tech" });
            AddStudent(new Student { ID = 2, Name = "Haris", City = "Missa", Course = "BSCS" });
            AddStudent(new Student { ID = 3, Name = "Uzair", City = "KhanaPull", Course = "B.Tech" });
            AddStudent(new Student { ID = 4, Name = "Ahthsham", City = "Jhelum", Course = "CS" });
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return items;
        }

        public Student AddStudent(Student student)
        {
            if (items == null)
            {
                throw new ArgumentNullException("student");
            }

            student.ID = next++;
            items.Add(student);
            return student;
        }
    }
}