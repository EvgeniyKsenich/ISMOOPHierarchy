using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class BANK_Administrator:Human, ICloneable, IComparable<BANK_Administrator>
    {
        public class MyComp_Default : IComparer<BANK_Administrator>
        {
            public int Compare(BANK_Administrator x, BANK_Administrator y)
            {
                return x.CompareTo(y);
            }
        }
        public class MyComp_Num : IComparer<BANK_Administrator>
        {
            public int Compare(BANK_Administrator x, BANK_Administrator y)
            {
                return x.Num.CompareTo(y.Num);
            }
        }
        public class MyComp_Surname : IComparer<BANK_Administrator>
        {
            public int Compare(BANK_Administrator x, BANK_Administrator y)
            {
                return x.Surname.CompareTo(y.Surname);
            }
        }


        protected int num;



        public BANK_Administrator(string name, string surname, int num) : base(name, surname)
        {
            this.num = num;
        }
        public int Num
        {
            set { num = value; }
            get { return num; }
        }

        public object Clone()
        {
            BANK_Administrator tmp = new BANK_Administrator(this.Name, this.Surname, this.Num);
            return tmp;
        }


        public int CompareTo(BANK_Administrator other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            int cmp = base.CompareTo(tmp);
            if (cmp == 0) return num.CompareTo(other.num);
            else
                return cmp;
        }
    }
}
