using System;
using System.Collections.Generic;
using System.Text;

namespace Pratice2
{
    class Mark
    {

        public string NameSubject { get; set; }
        private int _Marks;

        public Mark()
        {
        }

        public Mark(string nameSubject, int marks)
        {
            NameSubject = nameSubject;
            Marks = marks;
        }

        public int Marks
        {
            get => this._Marks;
            set
            {
                /*
                 * Co 2 cach xy ly tuy theo de bai dua ra:
                 * 1. Khi gia tri nhap vao sai => nen ra exception
                 * 2. Neu k nen ra loi => 
                 * Neu value < 0 => 0
                 * Neu value > 2 => 20
                 */
                //if (value < 0 || value > 20)
                //{
                //    throw new Exception();
                //}

                if (value < 0) this._Marks = 0;
                else if (value > 20) this._Marks = 20;
                else this._Marks = value;
            }

        }
    }
}
