using System;

namespace DAT
{
    public class Question : Learning
    {
        public string questiont_code { get; set; }
        public int type { get; set; }
        public int level { get; set; }

        public override string ToString()
        {
            return String.Format("Question_code: {0} Type: {1} Level: {2}", questiont_code, type, level);
        }

        //public string question_code;
        //public string content;
        //public int type;
        //public int level;

        //public void set_question_code(string code)
        //{
        //    question_code = code;
        //}

        //public string get_question_code()
        //{
        //    return question_code;
        //}

        //public void set_content(string question)
        //{
        //    content = question;
        //}

        //public string get_content()
        //{
        //    return content;
        //}

        //public void set_type(int type)
        //{
        //    this.type = type;
        //}

        //public int get_type()
        //{
        //    return type;
        //}

        //public void set_level(int level)
        //{
        //    this.level = level;
        //}

        //public int get_level()
        //{
        //    return level;
        //}
    }
}
