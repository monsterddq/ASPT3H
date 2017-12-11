using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface
{
    class Student : Person
    {
        private static string SchoolName;

        public static string _SchoolName
        {
            get {
                return SchoolName;
            }
            set {
                SchoolName = value;
            }
        }

        public Student()
        {
        }

        public Student(string name, int age) : base(name, age)
        {
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            base.Eat();
        }
    }
}
