using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class StudentDBContext : DbContext
    {
        public StudentDBContext() : base()
        {
        }
    }
}