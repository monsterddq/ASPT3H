using System;
using System.Collections.Generic;
using System.Text;

namespace Lession7PhamDucLong
{
    class Student
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }

        public Student(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public Student()
        {

        }
    }
}
