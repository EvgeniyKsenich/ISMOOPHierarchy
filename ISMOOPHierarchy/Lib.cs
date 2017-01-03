using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Lib:Human
    {
        public int[] blocked = new int[0];
        public Lib(string name, string surname):base(name, surname)
        {

        }

        public bool isBlocked(int nm)
        {
            return (blocked.Contains(nm));
         }

        public void AddInBlock(int nm)
        {
            if (!blocked.Contains(nm))
            {
                int[] tmp_mr = blocked;
                blocked = new int[blocked.Length + 1];
                CopyToMain(tmp_mr);
                blocked[blocked.Length - 1] = nm;
            }
        }
        private void CopyToMain(int[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                blocked[i] = tmp[i];
            }
        }
    }
}
