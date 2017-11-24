using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    interface IQuestion
    {
        List<Question> getAll();
        Question find(string question_code);
        void addQuestion(Question q);
        void modify(Question q);
        void remove(string question_code);
    }
}
