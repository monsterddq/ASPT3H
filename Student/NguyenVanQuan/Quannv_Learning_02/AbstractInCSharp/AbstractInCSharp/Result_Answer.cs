using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    class Result_Answer
    {
        string question_code;
        string correct_answer;
        string incorrect_anser;

        public Result_Answer(string question_code, string correct_answer, string incorrect_anser)
        {
            this.question_code = question_code;
            this.correct_answer = correct_answer;
            this.incorrect_anser = incorrect_anser;
        }

        public Result_Answer()
        {
        }
    }
}
