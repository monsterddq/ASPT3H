using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a= { };
            int[,] b = { };
            string menu;
            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1.Nhap mang 1 chieu a");
                Console.WriteLine("2.Nhap mang 2 chieu b");
                Console.WriteLine("3.In ra man hinh 2 mang a va b");
                Console.WriteLine("4.Tim so lon nhat trong mang a va mang b");
                Console.WriteLine("5.Tim so nho nhat trong mang a va b");
                Console.WriteLine("6.Sua doi gia tri 1 phan tu trong mang a hoac b");
                Console.WriteLine("7.Tinh tong 2 mang a va b");
                Console.WriteLine("8.Dem so phan tu chan va le trong 2 mang.");
                Console.WriteLine("9.Thoat chuong trinh.");
                Console.WriteLine("Nhap Menu: ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        int x; // so phan tu mang a
                        Console.WriteLine("Nhap mang 1 chieu a:");
                        NhapGiaTriMang("Nhap so phan tu cua mang a: ", out x);
                        a = new int[x];
                        for (int i = 0; i < x; i++)
                            NhapGiaTriMang($"Nhap phan tu thu {i}: ", out a[i]);
                        
                        Console.Clear();
                        break;
                    case "2":
                        int y;
                        Console.WriteLine("Nhap mang 2 chieu b:");
                        NhapGiaTriMang("Nhap so dong cua mang b: ", out x);
                        NhapGiaTriMang("Nhap so cot cua mang b: ", out y);
                        b = new int[x, y];
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                NhapGiaTriMang($"Nhap phan tu o vi tri {i},{j}: ", out b[i, j]);
                            }
                        }
                        break;
                    case "3":
                        if (!KiemTraMang(a, b)) break;
                        Console.WriteLine("Mang a:");
                        for (int i = 0, length = a.Length; i < length; i++)
                            Console.Write($"{a[i]}  ");
                        Console.WriteLine("\nMang b:");
                        foreach (int i in b)
                            Console.WriteLine($"{i}  ");
                        for (int i = 0, lengthx = b.GetLength(0); i < lengthx; i++)
                        {
                            for (int j = 0, lengthy = b.GetLength(1); j < lengthx; j++)
                            {
                                Console.Write(b[i,j]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        if (!KiemTraMang(a, b)) break;
                        Console.WriteLine($"So lon nhat trong mang a la: {SoLonNhat(a)}");
                        Console.WriteLine($"So lon nhat trong mang a la: {a.Max()}");
                        break;
                    default:
                        Console.WriteLine("Nhap menu sai. Vui long nhap lai.");
                        break;
                }
            }

        }

        static void NhapGiaTriMang(string s,out int x)
        {
            while (true)
            {
                Console.Write(s);
                if (!Int32.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Nhap sai gia tri. Gia tri nhap vao phai la so nguyen");
                else
                    break;
            }
        }

        static bool KiemTraMang(int[] a, int[,] b) {
            if (a.Length == 0 || b.Length == 0)
            {
                Console.WriteLine("Ban chua nhap gia tri cho mang a hoac b.");
                return false;
            }
            return true;
        }

        static int SoLonNhat(int[] a)
        {
            int max = a[0];
            for (int i = 1, length= a.Length; i < length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            return max;
        }
    }
}
