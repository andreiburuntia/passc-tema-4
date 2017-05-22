using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject
{
   interface IStudentsDao
   {
      List<Student> GetStudents();
      Student GetStudentById(string id);
      void DeleteStudentById(string id);
      void AddStudent(Student s);
   }
}
