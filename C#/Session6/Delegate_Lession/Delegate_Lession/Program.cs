using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lession
{
    class Program
    {
        // khai bao 1 delegate caculation
        public delegate int Caculation(int numOne, int numTwo);

        static int Addition(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        static int Subtration(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        static void Main(string[] args)
        {
            Caculation deleCaculation = new Caculation(Subtration);
            Console.WriteLine(deleCaculation(6,5));
            Console.ReadLine();
        }
    }
}
