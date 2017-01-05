using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Illnes:Human
    {
        string[] ToDo = new string[0];
        public Illnes(string name, string surname):base(name, surname)
        {

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

    }
}
