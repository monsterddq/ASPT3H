using System;
using System.Collections;

namespace Demo
{
    public class Program
    {
        /// <summary>
        ///   The main entry point for the application
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            string c = "";
            StudentService service = new StudentService()
            while (true)
            {
                switch (Expression)
                {
                    case "1":
                        Student student = new Student("1", "Hello", "0123456789");
                        service.addNew(student);
                        break;
                    case "2":
                        Log log = new Log();
                        log.setName();
                        log.setId();
                        break;
                    case "3":
                        service.getAll();
                        int choice = Convert.ToInt32(Console.ReadLine());
                        foreach (var student in studentLog)
                        {
                            if (student.getId() == choice)
                            {
                                var obj = student.getId() == choice;
                                ArrayList arrayList = new ArrayList();
                                arrayList.Add(obj);
                                Console.WriteLine("Diem chuyen can?(Y/n)");
                                string diemChuyenCan = Console.ReadLine();
                                arrayList.Add(diemChuyenCan);
                                Console.WriteLine("Bai tap ve nha?(Y/n)");
                                string btvn = Console.ReadLine();
                                arrayList.Add(btvn);
                            }
                        }
                        break;
                    case "4":
                        string str = Console.ReadLine();
                        if (str != "Y" || str != "y")
                        {
                            break;
                        }
                        else if (str == "n" || str == "N")
                        {
                            break;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Nhap sai");
                        break;
                }
            }
        }
    }
}
