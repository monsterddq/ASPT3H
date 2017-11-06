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
            std.setMark1 = 9;
            std.setMark1 = 8;
            Console.WriteLine(std.Print());
            Console.ReadLine();
        }
    }
}
