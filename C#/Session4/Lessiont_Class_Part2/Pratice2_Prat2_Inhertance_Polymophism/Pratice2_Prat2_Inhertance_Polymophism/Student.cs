using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice2_Prat2_Inhertance_Polymophism
{
    class Student : Person
    {


        int Grade;
        string Classes;
        string School;
        int Mark1;
        int Mark2;
        int Mark3;

        public Student():base()
        {}

        public Student(int grade, string classes, string school, int mark1, int mark2, int mark3):base()
        {
            Grade = grade;
            Classes = classes;
            School = school;
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }

        public int getGrade
        {
            //return this.Grade;
            get => this.Grade;
        }
        public int setGrade
        {
            set => this.Grade = value;
        }
        public string getClasses
        {
            //return this.Grade;
            get => this.Classes;
        }
        public string setClasses
        {
            set => this.Classes = value;
        }
        public string getSchool
        {
            //return this.Grade;
            get => this.School;
        }
        public string setSchool
        {
            set => this.School = value;
        }
        public int getMark1
        {
            //return this.Grade;
            get => this.Mark1;
        }
        public int setMark1
        {
            set => this.Mark1 = value;
        }
        public int getMark2
        {
            //return this.Grade;
            get => this.Mark2;
        }
        public int setMark2
        {
            set => this.Mark2 = value;
        }
        public int getMark3
        {
            //return this.Grade;
            get => this.Mark3;
        }
        public int setMark3
        {
            set => this.Mark3 = value;
        }

        public virtual string Print()
        {
            return $"{base.Print()}\nTôi đang là học sinh tại trường {this.School} , hiện tại tôi ở lớp {this.Grade}{this.Classes} ";
        }
    }
}
