using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class BANK_Administrator:Human, ICloneable, IComparable<BANK_Administrator>
    {
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
