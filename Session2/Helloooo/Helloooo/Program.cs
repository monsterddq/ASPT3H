using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloooo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, menu=0;
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1Nhap vao 2 so a,b");
                Console.WriteLine("2.Tinh tong 2 so a,b");
                Console.WriteLine("3.Tinh hieu 2 so a,b");
                Console.WriteLine("4.Tinh tich 2 so a,b");
                Console.WriteLine("5.Kiem tra 2 so a,b co phai 2 so nguyen to hay khong.");
                Console.Write("Nhap menu: ");

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("Nhap so a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap so b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(String.Format("Tong 2 so {0} + {1} la: {2}", a, b, a + b));
                        break;
                    case 3:
                        Console.WriteLine(String.Format("Hieu 2 so {0} - {1} la: {2}", a, b, a - b));
                        break;
                    case 4:
                        Console.WriteLine(String.Format("Tich 2 so {0} * {1} la: {2}", a, b, a * b));
                        break;
                    case 5:
                        string checka = KiemTraSoNguyenTo(a) ? "la so nguyen to" : "khong la so nguyen to";
                        Console.WriteLine(String.Format("{0} {1}", a, checka));
                        checka = KiemTraSoNguyenTo(a) ? "la so nguyen to" : "khong la so nguyen to";
                        Console.WriteLine(String.Format("{0} {1}", b, checka));
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap sai menu vui long nhap lai");
                        break;
                }
            }
        }

        public static bool KiemTraSoNguyenTo(int a)
        {
            int dem = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) dem++;
            }
            return dem > 0 ? false : true;
        }
    }
}
