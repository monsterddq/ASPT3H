using System;

namespace Pratice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            int menu = 0;
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Nhập thông tin học sinh.");
                Console.WriteLine("2.Nhập điểm của học sinh.");
                Console.WriteLine("3.Hiển thị thông tin học sinh");
                Console.WriteLine("4.Tính điểm trung bình môn của học sinh đó.");
                Console.WriteLine("5.Xếp loại học lực của học sinh.");
                Console.WriteLine("6.Thay đổi thông tin học sinh.");
                Console.WriteLine("7.Thoát");
                Console.Write("Chon menu: ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        setStudent(std);
                        break;
                    case 2:
                        setStudentMark(std);
                        break;
                    case 3:
                        Console.WriteLine(std.ToString());
                        break;
                    case 4:
                        Console.WriteLine(DiemTrungBinh(std));
                        break;
                    case 5:
                        float d = DiemTrungBinh(std);
                        if (d >= 0 || d <= 8) Console.WriteLine("Xep loai: Yeu");
                        else if (d > 8 || d <= 12) Console.WriteLine("Xep loai: Kha");
                        else if (d > 12 || d <= 16) Console.WriteLine("Xep loai: Trung Binh");
                        else Console.WriteLine("Xep loai: Gioi");
                        break;
                    default:
                        break;
                }
            }
        }

        private static float DiemTrungBinh(Student std)
        {
            float total = 0;
            foreach (var item in std.Marks)
            {
                total += item.Marks;
            }
            return total / std.Marks.Length;
        }

        static void setStudent(Student std)
        {
            Console.WriteLine("Nhap thong tin hoc sinh:");
            Console.Write("Name: ");
            std.Name = Console.ReadLine();
            Console.Write("Age: ");
            std.Age = int.Parse(Console.ReadLine());
            Console.Write("Address: ");
            std.Address = Console.ReadLine();
            Console.Write("Email: ");
            std.Email = Console.ReadLine();
           
        }

        static void setStudentMark(Student std)
        {
            foreach (var item in std.Marks)
            {
                Console.Write($"Nhap diem {item.NameSubject}: ");
                item.Marks = int.Parse(Console.ReadLine());
            }
        }
    }
}
