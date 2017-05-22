using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject
{
   class Horoscope
   {
      public static string PredictIncreaseDecrease(string id)
      {
         string result = "";

         StudentDao dbAccessLayer = new StudentDao();
         Student student = dbAccessLayer.GetStudentById(id);

         int sum = 0;
         for (int i = 0; i < student.Name.Length; i++)
         {
            sum += (int)student.Name[i];
         }
         for (int i = 0; i < student.Id.Length; i++)
         {
            sum += (int)student.Id[i];
         }

         result = sum % 2 == 1 ? "grade will go up" : "grade will go down";

         return result;
      }

      public static int PredictHowMany()
      {
         int count = 0;

         StudentDao dbAccessLayer = new StudentDao();
         List<Student> students = dbAccessLayer.GetStudents();

         foreach (Student s in students)
         {
            if (s.Grade > 8 && PredictIncreaseDecrease(s.Id) == "grade will go down")
            {
               count++;
            }
         }

         return count;
      }

      public static Boolean PredictGoodDay(string id)
      {
         StudentDao dbAccessLayer = new StudentDao();

         return ((int)DateTime.Now.Day + (int)dbAccessLayer.GetStudentById(id).Name[0]) % 2 == 1;
      }
   }
}
