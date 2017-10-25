using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Program
    {
        static int c = 10;
        int d = c;
        
        static void Main(string[] args)
        {
            //int b = 10;
            //Console.WriteLine(c);
            //// block
            //{
            //    // nested block
            //}
            //Console.ReadLine();
            //TinhTong();
            //int b = 0;
            //int a = 1;
            //b = a >= 0 ? 1 : 2;
            // condition ? true : false => value
            // variable = condition ? true : false;
            // ?: return value
            //a += a;
            //a = a + a;
            //if (a >= 0)
            //    b = 1;
            //else
            //    b = 2;
            //var c = "123";
            //c = null;
            //Console.WriteLine(c ?? "123");
            // variable1 ?? variable2:
            // neu bien 1 mang gia tri null thi bieu thuc tra ve gia tri bien 2
            //Console.WriteLine(b);
    //        int gio = 17;
    //        switch (gio)
    //        {
    //            case 6:
    //                Console.WriteLine("Dang gio sang");
    //                break;
    //            case 12:
    //                Console.WriteLine("Dang bua trua");
    //                break;
    //            default:
    //                Console.WriteLine("Dang bua toi");
    //                break;
    //        }
    //        if (gio > 0)
    //        {
    //            if (gio > 5)
    //            {
    //                    // khoi lenh nested if
    //            }
    //        }
    ////        if (condition)
    ////        {
    ////           chay khi codition tra ve  true
    ////        }
    ////        else
    ////{
    ////            chay khi codition tra ve false
    ////}
    //        int[] a = new int[] {1,2,3,4};
    //        for (int i = 0, length = a.Length; i < length; i++)
    //        {
    //            Console.WriteLine(a[i]);
    //        }
    //        for(;;)
    //        {
    //            Console.WriteLine(1);
    //        }
            //int a = 5, c = 10;

            //var b = a++ + c-- * c-- + a - c--;
            //Console.WriteLine(b);
            //Console.WriteLine(a);
            //Console.WriteLine(c);
            // b= 5 + 10 * 9 + 6 - 8;
            // a = 6 
            // c = 7
            var b = "";
            Console.WriteLine("Nhap vao gia tri a");
            b = Console.ReadLine();
            Console.WriteLine(b);
        }

        public static void TinhTong()
        {
            int a = 0;
            Console.WriteLine(c);
        }
    }
}
