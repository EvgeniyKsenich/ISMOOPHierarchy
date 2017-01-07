using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Human: ICloneable, IComparable<Human>
    {
        protected string name;
        protected string surname;
        
        public Human()
        {
            DEFAULT();
        }
        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Human(Human hm)
        {
            this.name = hm.name;
            this.surname = hm.surname;
        }

        protected void DEFAULT()
        {
            name = "NONE";
            surname = "NONE";
        }
        public string Name
        {
            get { return name; }
            set { name=value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        
        public virtual void Print()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Surname:" + Surname);
        }

        public object Clone()
        {
            Human tmp = new Human(this.name, this.surname);
            return tmp;
        }

        public int CompareTo(Human other)
        {
            if (other == null) return 1;
            if(this.Name != other.Name)
                return Name.CompareTo(other.Name);
            else
                return Surname.CompareTo(other.Surname);
        }
    }
}
