using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Book
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
    }
}
