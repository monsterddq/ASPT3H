using System;
using System.Collections.Generic;

namespace Demo
{
    interface IQuestion
    {
        void getAll();
        string find(string question_code);
        void addQuestion(Question q);
        void modify(Question q);
        void remove(Question q);
    }
}
