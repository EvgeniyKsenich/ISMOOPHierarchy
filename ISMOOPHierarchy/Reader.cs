using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Reader: Human, ICloneable, IComparable<Reader>
    {
        public class MyComp_Default : IComparer<Reader>
        {
            public int Compare(Reader x, Reader y)
            {
                return x.CompareTo(y); 
            }
        }
        public class MyComp_Books_Count : IComparer<Reader>
        {
            public int Compare(Reader x, Reader y)
            {
                return x.LENTH_B.CompareTo(y.LENTH_B);
            }
        }
        public class MyComp_Surname : IComparer<Reader>
        {
            public int Compare(Reader x, Reader y)
            {
                return x.Surname.CompareTo(y.Surname);
            }
        }


        protected int[] book = new int[0];
        public Reader(string name, string surname):base(name, surname)
        {

        }

        protected int[] BK
        {
            get { return book; }
            set { book = value; }
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

        public int LENTH_B
        {
            get { return book.Length; }
        }

        public int CompareTo(Reader other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            int cmp =  base.CompareTo(tmp);

            if (cmp == 0) return LENTH_B.CompareTo(other.LENTH_B);
            else
                return cmp;
        }
        public object Clone()
        {
            Reader tmp = new Reader(this.name, this.surname);
            tmp.BK = this.BK;
            return tmp;
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
