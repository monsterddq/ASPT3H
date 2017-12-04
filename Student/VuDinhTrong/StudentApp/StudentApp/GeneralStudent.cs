using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal abstract class GeneralStudent : IGeneralStudent
    {
        public StudentDBContext db = new StudentDBContext();

        public abstract void Add(object obj);
    }
}