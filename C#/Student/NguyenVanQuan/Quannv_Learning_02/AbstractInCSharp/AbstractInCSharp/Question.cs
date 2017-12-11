using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    public class Question: Learning
    {
        public string question_code {get;set;}
        public int type {get;set;}
        public int level {get;set;}

        public Question(string question_code, int type, int level):base()
        {
            this.question_code = question_code;
            this.type = type;
            this.level = level;
        }

        public Question():base()
        {
        }
    }

}
