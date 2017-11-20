using System;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Student._SchoolName = "abc";
            Console.WriteLine(std is IAction1);

            Console.WriteLine("Hello World!");
        }
    }
}
