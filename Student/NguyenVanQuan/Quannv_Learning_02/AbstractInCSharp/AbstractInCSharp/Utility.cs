using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    public static class Utility
    {
        public static List<Question> list_question = new List<Question>();
        public static List<Answer> list_answer = new List<Answer>();
        public static List<Result_Answer> list_result_answer;

        //internal static List<Question> List_question { get => list_question; set => list_question = value; }
        //internal static List<Answer> List_answer { get => list_answer; set => list_answer = value; }
        //internal static List<Result_Answer> List_result_answer { get => list_result_answer; set => list_result_answer = value; }
    }
}
