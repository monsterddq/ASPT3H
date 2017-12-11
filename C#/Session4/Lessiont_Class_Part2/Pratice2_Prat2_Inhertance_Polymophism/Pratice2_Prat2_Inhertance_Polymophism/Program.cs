using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice2_Prat2_Inhertance_Polymophism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.setName = "Phan Van A";
            std.setAge = 20;
            std.setAddress = "Ha Noi";
            std.setPhone = "019283658";
            std.setGrade = 12;
            std.setClasses = "A1";
            std.setSchool = "Le Hong Phong";
            std.setMark1 = 10;
            std.setMark2 = 9;
            std.setMark3 = 8;
            Console.WriteLine(std.Print());

            Employee em = new Employee("T3H", "th3@gmail.com", "IT", 5000);
            IPerson p = new PersonImp();
            PersonImp pimp = new PersonImp();
            Console.WriteLine(p.DiemTrungBinh(std));
            Console.WriteLine(p.TinhTienLuong(em,12));
            Console.ReadLine();
        }
    }
}
