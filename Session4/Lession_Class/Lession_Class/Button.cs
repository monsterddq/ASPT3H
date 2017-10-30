using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_Class
{
    public partial class Button
    {
        public Button()
        {
            // Day la constructor khong tham so
        }

        public Button(string text, string color, string type) {
            // Day la constructor co tham so
            this.text = text;
            this.color = color;
            this.type = type;
        }

        // cac field
        public string text;
        public string color;
        string type;
        // property
        public string action { get; set; }

        public string _Type
        {
            get {
                return type;
            }
            set {
                type = value;
            }
        }


        public void Click()
        {
            // method
            Console.WriteLine("Day la su kien click cua button");
        }

        void Hover()
        {
            Console.WriteLine("Day la su kien hover cua button");
        }

        public override string ToString() => $"Text: {text}, Color: {color}, Type: {type}";
    }

    public partial class Button
    {
        // class partial 
        public string events { get; set; }
    }

    public class Submit : Button
    {
        // class ke thua tu 1 class khac
        public Submit() : base()
        {
        }

        public Submit(string link) : base()
        {
            Link = link;
        }

        public string Link { get; set; }
    }

    public abstract class Peopel
    {
        // class abstract dinh nghia cau truc clas chung
        // co the chua field
        // method co the chua body hoac khong chua body voi tu khoa abstract
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public abstract void Go(int number);
    }

    interface Action1
    {
        // Day la interface
        // duoc su dung de dinh nghia cac ham
        void Gos();
    }

    interface Action2
    {
        void Gos2();
    }
    public class Student : Peopel, Action1, Action2
    {
        // class co the ke thua tu 1 class khac 
        // class cos the implement tu nhieu interface
        public override void Go(int number)
        {
            throw new NotImplementedException();
        }

        public void Gos()
        {
            throw new NotImplementedException();
        }

        public void Gos2()
        {
            throw new NotImplementedException();
        }
    }


    public sealed class Employee
    {
        // class nay khong the implement boi cac class khac
    }
}
