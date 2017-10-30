using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button("Get Link", "red", "button");
            Console.WriteLine(btn);
            Console.WriteLine(btn._Type);
            btn.Click();
            Submit sub = new Submit();
            Peopel p = new Peopel();
            Console.ReadLine();
        }
    }
}
