using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Abiturient:Human, ICloneable, IComparable<Abiturient>
    {
        public Abiturient(string name, string surname):base(name, surname)
        {

        }

        public object Clone()
        {
            return new Abiturient(this.Name, this.Surname);
        }
        public int CompareTo(Abiturient other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            return base.CompareTo(tmp);
        }
    }
}
