using System;
using System.Collections.Generic;
using System.Text;

namespace Pratice2
{
    class Student
    {

        public Student()
        {
            Mark[] m =
            {
                new Mark("Maths",0),
                new Mark("Lit",0),
                new Mark("Physic",0),
                new Mark("Chemistry",0),
                new Mark("Biology",0)
            };
            this.Marks = m;
        }

        public Student(string name, int age, string address, string email, Mark[] marks)
        {
            Name = name;
            Age = age;
            Address = address;
            Email = email;
            Marks = marks;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public Mark[] Marks { get; set; }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("Thong tin hoc sinh: ");
            st.AppendLine($"Name: {this.Name}");
            st.AppendLine($"Age: {this.Age}");
            st.AppendLine($"Address: {this.Address}");
            st.AppendLine($"Email: {this.Email}");
            foreach (var item in this.Marks)
            {
                st.AppendLine($"{item.NameSubject}: {item.Marks}");
            }
            return st.ToString();
        }
    }
}
