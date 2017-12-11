using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLS
{
    class Program
    {

        class Arrays<T>
        {
            T[] array;
            public void Initialize(int max)
            {
                array = new T[max];
            }
            public void GetType()
            {
                System.Type t = typeof(T);
                Console.WriteLine(String.Format("Kieu du lieu cua Generic: {0}",typeof(T).FullName));
            }

            public void FetchLengthArray()
            {
                Console.WriteLine(String.Format("So Phan Tu cua Mang Generic: {0}", array.Length));
            }

        }

        static void Main(string[] args)
        {
            //Arrays<string> array = new Arrays<string>();
            //Arrays<int> arrays = new Arrays<int>();
            //arrays.Initialize(5);
            //arrays.GetType();
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            foreach (var item in LoopsYiedl(list))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static List<string> Loops(List<int> list)
        {
            List<string> lists = new List<string>();
            foreach (var item in list)
                lists.Add(item.ToString());
            return lists;
        }

        public static IEnumerable<string> LoopsYiedl(List<int> list)
        {
            foreach (var item in list)
                yield return item.ToString();
        }


    }
}
