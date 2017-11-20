using System;
using System.Collections.Generic;

namespace DAT
{
    interface IQuestion
    {
        List<Question> GetAll();
        Question Find(string question_code);
        void Add(Question q);
        void Modify(Question q);
        void Remove(string question_code);
    }
}
