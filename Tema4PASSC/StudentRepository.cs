using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4PASSC
{
   class StudentRepository
   {
      public List<Student> GetStudents()
      {
         StudentDBContext studentDBContext = new StudentDBContext();
         return studentDBContext.Students.ToList();
      }
   }
}
