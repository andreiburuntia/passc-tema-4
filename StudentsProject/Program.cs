using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject
{
   class Program
   {
      static void Main(string[] args)
      {
         //init database
         SeedDb();

         //do things


         //delete database
         PurgeDb();

      }
      static void SeedDb()
      {
         StudentDao dbAccessLayer = new StudentDao();
         for (var i = 0; i < 10; i++)
         {
            dbAccessLayer.AddStudent(new Student { Id = Guid.NewGuid().ToString(), Name = "Student" + i.ToString(), Grade = i });
         }
      }
      static void PurgeDb()
      {
         StudentDao dbAccessLayer = new StudentDao();
         dbAccessLayer.RemoveAll();
      }
   }
}
