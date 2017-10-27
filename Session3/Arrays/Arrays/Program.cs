using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] stdArray; // khai bao
            ////stdArray = new int[] { }; // new int[so phan tu cua mang] {cac phan tu cach nhau boi dau phay};
            //stdArray = new int[5] { 1, 2, 3, 4, 4 }; // buoc khoi tao
            //int[] stdArray2 = new int[5] { 2, 3, 4, 5, 5 }; // vua khai bao vua khoi tao
            //string[] name = { "a", "c", "d" };
            //name[0] = "Phan Van A"; // thay doi gia tri phan tu thu 0 trong mang

            ////Console.WriteLine(name[0]); // ten_mang[index] lay ra gia tri thu index trong mang
            ////Console.WriteLine(stdArray.Length);

            //int[] count = new int[10];
            //int counter = 0;


            //for (int i = 0; i < 10; i++)
            //{
            //    // voi i = 0
            //    count[i] = counter++; // counter = 0; => count[0] = 0;
            //    Console.WriteLine($"Gia tri cua phan tu thu {i} la: {count[i]}"); // gia tri couter da duoc tang
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"GIa tri phan tu thu {i} trong mang count la: {count[i]}");
            //}
            //// mang nhap lay du lieu tu ngoai
            //// => khong biet truoc duoc so phan tu trong mang
            //int[] aInput = new int[] { };
            //// code dung vong lap for lay du lieu cua mang don gian va toi uu
            ////for (int i = 0, length = aInput.Length; i < length; i++)
            ////{
            ////}

            // Mang nhieu chieu
            int[,] stdName; // khai bao
            //stdName = new int[4, 5]; // Retangular = > cac phan tu trong mang la nhung mang co cung so phan tu
            stdName = new int[2, 2] { { 2, 2 }, { 1, 1 } };
            //int counter = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        stdName[i, j] = counter++;
            //    }
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine($"Phan tu dong {i} va cot {j} la: {stdName[i, j]}");
            //    }
            //}
            //phan biet ""  va Null


            //Array a = Array.CreateInstance(typeof(int), 10);
            //a.GetEnumerator();




            Console.ReadLine();
        }
    }
}
