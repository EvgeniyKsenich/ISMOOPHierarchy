using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Kurs_Archive:ICloneable, IComparable<Kurs_Archive>
    {
        Human[] tet = new Human[0];
        Kurs[] kr = new Kurs[0];
        protected int Leanth
        {
            get { return tet.Length; }
        }
        public Kurs[] KR
        {
            set { kr = value; }
            get { return kr; }
        }
        public Human[] TET
        {
            set { tet = value; }
            get { return tet; }
        }
        public void AddCourse(string name, Human hm, double mark)
        {
            Kurs[] tmp_client = kr;
            kr = new Kurs[kr.Length + 1];
            CopyToMain(tmp_client);
            kr[kr.Length - 1] = new Kurs(name);

            Human[] tmp_hm = tet;
            tet = new Human[tet.Length + 1];
            CopyToMain(tmp_hm);
            tet[tet.Length - 1] = new Human(hm);
        }
        //private void CopyToMain(double[] tmp)
        //{
        //    int lic = tmp.Length;
        //    for (int i = 0; i < lic; i++)
        //    {
        //        marks[i] = tmp[i];
        //    }
        //}
        private void CopyToMain(Kurs[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                kr[i] = tmp[i];
            }
        }
        private void CopyToMain(Human[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                tet[i] = tmp[i];
            }
        }

        public object Clone()
        {
            Kurs_Archive tmp = new Kurs_Archive();
            tmp.TET = this.TET;
            tmp.KR = this.KR;
            return tmp;
        }

        public int CompareTo(Kurs_Archive other)
        {
            return other.Leanth.CompareTo(other.Leanth);
        }
    }
}
