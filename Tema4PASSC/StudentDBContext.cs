﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tema4PASSC
{
   class StudentDBContext :  DbContext
   {
      public DbSet<Student> Students { get; set; }
   }
}
