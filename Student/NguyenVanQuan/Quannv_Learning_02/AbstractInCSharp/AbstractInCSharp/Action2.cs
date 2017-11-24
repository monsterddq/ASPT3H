using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    class Action2 : IAnswer
    {

        public void addAnswer(Answer a)
        {
            Utility.List_answer.Add(a);
        }

        public Answer find(string answer_code)
        {
            for (int i = 0; i < Utility.List_answer.Count; i++)
            {
                if (Utility.List_answer[i] == null)
                {
                    continue;
                }
                if (Utility.List_answer[i].answer_code == answer_code)
                {
                    return Utility.List_answer[i];
                }
            }
            return null;
        }

        public List<Answer> getAll()
        {
            return Utility.List_answer;
        }

        public void modifile(int index, string content)
        {
            Utility.List_answer[index].content = content;
        }

        public void remove(string answer_code)
        {
            Utility.List_answer[int.Parse(answer_code)] = null;
        }
    }
}
