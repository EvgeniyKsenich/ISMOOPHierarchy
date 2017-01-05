using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Reader:Human
    {
        protected int[] book = new int[0];
        public Reader(string name, string surname):base(name, surname)
        {

        }

        public void AddInBook(int nm)
        {
            if (!book.Contains(nm))
            {
                int[] tmp_mr = book;
                book = new int[book.Length + 1];
                CopyToMain(tmp_mr);
                book[book.Length - 1] = nm;
            }
        }
        private void CopyToMain(int[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                book[i] = tmp[i];
            }
        }
    }
}
