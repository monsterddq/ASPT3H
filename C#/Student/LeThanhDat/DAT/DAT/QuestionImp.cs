using System;
using System.Collections.Generic;


namespace DAT
{
    public class QuestionImp : IQuestion
    {
        public List<Question> GetAll()
        {
           return Utility.ListQuestion;

        }

        

        public Question Find(string code)
        {
            return this.GetAll().Find(w => w.questiont_code.Equals(code));
        }

        public void Add(Question q)
        {
            Utility.ListQuestion.Add(q);
        }

        public void Modify(Question q)
        {
            
        }

        public void Remove(string question_code)
        {
            Question q = Find(question_code);
            Utility.ListQuestion.Remove(q);
        }

        //public void getAll()
        //{
        //    return;
        //}
    }
}
