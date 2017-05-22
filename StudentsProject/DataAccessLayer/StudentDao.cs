using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject
{
   class StudentDao : IStudentsDao
   {
      public void AddStudent(Student s)
      {
         using (StudentsEntities context = new StudentsEntities())
         {
            context.Students.Add(s);
            context.SaveChanges();
         }
      }

      public void DeleteStudentById(string id)
      {
         using (StudentsEntities context = new StudentsEntities())
         {
            foreach(Student s in context.Students)
            {
               if (s.Id == id)
                  context.Students.Remove(s);
            }
            context.SaveChanges();
         }
      }

      public Student GetStudentById(string id)
      {
         Student result = new Student();
         using (StudentsEntities context = new StudentsEntities())
         {
            result = context.Students.FirstOrDefault(s => s.Id == id);
         }
         return result;
      }

      public List<Student> GetStudents()
      {
         List<Student> result = new List<Student>();
         using (StudentsEntities context = new StudentsEntities())
         {
            result = context.Students.ToList();
         }
         return result;
      }
      public void RemoveAll()
      {
         using (StudentsEntities context = new StudentsEntities())
         {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Students");
         }
      }
   }
}
