using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Book: ICloneable, IComparable<Book>
    {
        protected string name;
        protected bool ishere;

        public Book(string name, bool here)
        {
            this.name = name;
            ishere = here;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Here
        {
            get { return ishere; }
            set { ishere = value; }
        }

        public object Clone()
        {
            Book tmp = new Book((string)this.Name, this.Here);
            return tmp;
        }

        public int CompareTo(Book other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
