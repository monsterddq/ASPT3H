using System;

namespace Class_part2
{
    class Program
    {
        static void Print(string a,string b) => Console.WriteLine(a);

        public static void Add(ref int a)
        {
            a = a + 1;
        }

        public static void Add2(out int a) {
            a = 0;
            a = a + 1;
        }

        public static void Add1(int a)
        {
            a = a + 1;
            Console.WriteLine($"Gia tri trong ham khong tham chieu la: {a}");
        }
        static void Main(string[] args)
        {
            Student std = new Student();
            int a;
            int b = 0;
            int c;
            Add(ref a);
            Add2(out c);
            Add1(b);
            Console.WriteLine($"gia tri cua a la: {a}");
            Console.WriteLine($"gia tri cua b la: {b}");
            Console.WriteLine("Hello World!");
        }
    }
}
