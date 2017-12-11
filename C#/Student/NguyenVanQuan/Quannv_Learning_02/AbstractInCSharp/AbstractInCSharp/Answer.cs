using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    class Answer: Learning
    {
        public string answer_code {get;set;}

        public Answer(string answer_code):base()
        {
            this.answer_code = answer_code;
        }

        public Answer():base()
        {

        }
    }
}
