using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class BANK_Administrator:Human
    {
        protected int num;

        public BANK_Administrator(string name, string surname, int num) : base(name, surname)
        {
            this.num = num;
        }
    }
}
