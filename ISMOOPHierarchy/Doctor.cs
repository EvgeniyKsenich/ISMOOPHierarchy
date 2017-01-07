using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Doctor:Human,ICloneable, IComparable<Doctor>
    {
        public Doctor(string name, string surname):base(name, surname)
        {

        }

        public object Clone()
        {
            Doctor tmp = new Doctor(this.Name, this.Surname);
            return tmp;
        }
        public int CompareTo(Doctor other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            int cmp = base.CompareTo(tmp);
            return cmp;
        }
    }
}
