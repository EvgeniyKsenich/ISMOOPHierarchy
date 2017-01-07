using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Teatcher:Human, ICloneable, IComparable<Teatcher>
    {
        Kurs[] kr = new Kurs[0];

        public Teatcher(string name, string surname):base(name, surname)
        {

        }

        protected Kurs[] KR 
        {
            get { return kr; }
            set { kr = value; }
        }
        public void StartCourse(string name)
        {
            Kurs[] tmp_client = kr;
            kr = new Kurs[kr.Length + 1];
            CopyToMain(tmp_client);
            kr[kr.Length - 1] = new Kurs(name);
        }
        public void StopCourse(int nm)
        {
            if (nm - 1 > -1 && nm - 1 < kr.Length)
            {
                kr[nm - 1].SetMarks();
                DeleteFromMain(nm-1);
            }
        }

        private void DeleteFromMain(int nm)
        {
            Kurs[] tmp_client = kr;
            kr = new Kurs[kr.Length - 1];
            for(int i=0, o=0;i<kr.Length;i++)
            {
                if (i != nm - 1)
                {
                    kr[o] = tmp_client[i];
                    o++;
                }
            }
        }

        public override void Print()
        {
            base.Print();
            for(int i=0;i<kr.Length;i++)
            {
                Console.WriteLine("Course: " + kr[i].Name);
                kr[i].Print();
            }
        }
        public void Prindourse()
        {
            for (int i = 0; i < kr.Length; i++)
            {
                Console.WriteLine(i+")Course: " + kr[i].Name);
                kr[i].Print();
            }
        }
        public void PutOnCurs(int nm, int st_nm)
        {
            if (nm - 1 > -1 && nm - 1 < kr.Length)
            {
                kr[nm - 1].AddInCourse(st_nm);
            }
        }

        private void CopyToMain(Kurs[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                kr[i] = tmp[i];
            }
        }
        public int LENTH_B
        {
            get { return kr.Length; }
        }


        public object Clone()
        {
            Teatcher tmp = new Teatcher(this.Name, this.Surname);
            tmp.KR = this.KR;
            return tmp;
        }

        public int CompareTo(Teatcher other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            int cmp = base.CompareTo(tmp);

            if (cmp == 0) return LENTH_B.CompareTo(other.LENTH_B);
            else
                return cmp;
        }
    }
}
