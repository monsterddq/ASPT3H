using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    interface IAnswer
    {
        List<Answer> getAll();
        Answer find(string answer_code);
        void addAnswer(Answer a);
        void modifile(Answer a);
        void remove(string question_code);
    }
}
