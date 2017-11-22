using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    abstract class Learning
    {
        string content {get;set;}

        public Learning(string content)
        {
            this.content = content;
        }

        public Learning()
        {
        }
    }
}
