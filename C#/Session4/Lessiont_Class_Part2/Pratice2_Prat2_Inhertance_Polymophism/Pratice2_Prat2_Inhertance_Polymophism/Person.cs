using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice2_Prat2_Inhertance_Polymophism
{
    class Person
    {
        public Person()
        {
        }

        public Person(string name, int age, string address, string phone)
        {
            Name = name;
            Age = age;
            Address = address;
            Phone = phone;
        }

        private string Name;
        private int Age;
        private string Address;
        private string Phone;
        public string getName
        {
            get => this.Name;
        }
        public string setName
        {
            set => this.Name = value;
        }

        public int getAge
        {
            get => this.Age;
        }
        public int setAge
        {
            set => this.Age = value;
        }
        public string getAddress
        {
            get => this.Address;
        }
        public string setAddress
        {
            set => this.Address = value;
        }
        public string getPhone
        {
            get => this.Phone;
        }
        public string setPhone
        {
            set => this.Phone = value;
        }

        public string Print()
        {
            //return "Xin chao, Toi ten la " + this.Name + ", nam nay toi " + this.Age + " tuoi.\nRat vui duoc gap ban. Hay goi cho toi theo so nay" + this.Phone;
            //return String.Format("Xin chào, Tôi tên là {0},năm nay tôi {1} tuổi.\nRất vui được gặp bạn.Hãy gọi cho tôi theo số này { 2}.", this.Name, this.Age, this.Phone);
            return $"Xin chào, Tôi tên là {this.Name},năm nay tôi {this.Age} tuổi.\nRất vui được gặp bạn.Hãy gọi cho tôi theo số này {this.Phone}.";
        }

        //public string Print1() => $"Xin chào, Tôi tên là {this.Name},năm nay tôi {this.Age} tuổi.\nRất vui được gặp bạn.Hãy gọi cho tôi theo số này {this.Phone}.";
        public int GetAgeAtYear(int year)
        {
            int namsinh = DateTime.Now.Year - this.Age; // lay nam hien tai - so tuoi hien tai => nam sinh
            int age = year - namsinh;
            if (age < 0)
            {
                Console.WriteLine("Luc do ban chua sinh ra");
                return 0;
            }
            else if (age == 0)
            {
                Console.WriteLine("Luc do ban dang o trong bung me");
                return 0;
            }
            else
            {
                return age;
            }
        }
    }
}
