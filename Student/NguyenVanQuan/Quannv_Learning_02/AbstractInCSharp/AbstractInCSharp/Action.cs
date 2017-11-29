using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    class Action : IQuestion
    {
        public void addQuestion(Question q)
        {
            Utility.list_question.Add(q);
        }

        public Question find(string question_code)
        {
            return Utility.list_question.Find(w => w.question_code.Equals(question_code));
            //for (int i = 0; i < Utility.list_question.Count; i++) {
            //    if(Utility.list_question[i] == null)
            //    {
            //        continue;
            //    }
            //    if(Utility.list_question[i].question_code == question_code)
            //    {
            //        return Utility.list_question[i];
            //    }
            //}
            //return null;
        }

        public List<Question> getAll()
        {
            return Utility.list_question;
        }

        public void modifile(Question q)
        {
            var r = Utility.list_question.Find(w => w.question_code.Equals(q.question_code));
            if (r == null)
                throw new Exception();
            else
            {
                r.question_code = q.question_code;
                r.level = q.type;
                r.type = q.type;
            }
        }

        public void remove(string question_code)
        {
            ArrayList a = new ArrayList();
            a.Add(5);
            a.Add("string");
            var r = Utility.list_question.Find(w => w.question_code.Equals(question_code));
            if (r == null)
                throw new Exception();
            else
            {
                Utility.list_question.Remove(r);
            }
           
        }
    }
}
