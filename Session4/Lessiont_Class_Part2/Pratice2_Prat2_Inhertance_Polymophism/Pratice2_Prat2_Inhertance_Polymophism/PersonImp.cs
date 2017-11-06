using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice2_Prat2_Inhertance_Polymophism
{
    class PersonImp : IPerson
    {
        public float DiemTrungBinh(Student std)
        {
            return (std.getMark1 + std.getMark2 + std.getMark3) / 3;
        }

        public float TinhTienLuong(Employee emp, int month)
        {
            
        }
    }
}
