using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Illnes:Human, ICloneable, IComparable<Illnes>
    {
        string[] ToDo = new string[0];
        public Illnes(string name, string surname):base(name, surname)
        {

        }
        protected string[] TD
        {
            get { return ToDo; }
            set { ToDo = value; }
        }
        protected int TD_L
        {
            get { return ToDo.Length; }
        }

        public void AddInDoings(string nm)
        {
            if (!ToDo.Contains(nm))
            {
                string[] tmp_mr = ToDo;
                ToDo = new string[ToDo.Length + 1];
                CopyToMain(tmp_mr);
                ToDo[ToDo.Length - 1] = nm;
            }
        }
        private void CopyToMain(string[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                ToDo[i] = tmp[i];
            }
        }
        public void DeleteFromMain(int nm)
        {
            string[] tmp_client = ToDo;
            ToDo = new string[ToDo.Length - 1];
            for (int i = 0, o = 0; i < ToDo.Length; i++)
            {
                if (i != nm - 1)
                {
                    ToDo[o] = tmp_client[i];
                    o++;
                }
            }
        }





        public object Clone()
        {
            Illnes tmp = new Illnes(this.Name, this.Surname);
            tmp.TD = this.TD;
            return tmp;
        }
        public int CompareTo(Illnes other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            int cmp = base.CompareTo(tmp);

            if (cmp == 0) return TD_L.CompareTo(other.TD_L);
            else
                return cmp;
        }
    }
}
