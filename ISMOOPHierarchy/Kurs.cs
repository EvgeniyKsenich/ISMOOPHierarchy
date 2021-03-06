﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Kurs : ICloneable, IComparable<Kurs>
    {
        protected string course_name;
        protected int[] student_num = new int[0];
        protected int[] marks = new int[0];
        
        //public string Name
        //{
        //    get { return course_name; }
        //}
        public Kurs(string name)
        {
            course_name = name;
        }
        protected int TD_L
        {
            get { return student_num.Length; }
        }
        protected int[] STnm
        {
            get { return student_num; }
            set { student_num = value; }
        }

        protected int[] MR
        {
            get { return marks; }
            set { marks = value; }
        }

        public void SetMarks()
        {
            Console.WriteLine("Set marks:");
            for(int i=0;i<marks.Length;i++)
            {
                Console.WriteLine("Student " + student_num[i]);
                int nm = int.Parse(Console.ReadLine());
                marks[i] = nm;
            }
        }

        public void AddInCourse(int nm)
        {
            if (!student_num.Contains(nm))
            {
                int[] tmp_mr = student_num;
                student_num = new int[student_num.Length + 1];
                CopyToMain(tmp_mr);
                student_num[student_num.Length - 1] = nm;

                marks = new int[marks.Length + 1];
            }
        }
        private void CopyToMain(int[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                student_num[i] = tmp[i];
            }
        }

        public string Name
        {
            get { return course_name; }
            set { course_name = value; }
        }
        public int[] Mas
        {
            get { return student_num; }
            set { student_num = value; }
        }
        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < student_num.Length; i++) Console.Write(student_num[i]+" ");
        }

        public object Clone()
        {
            Kurs tmp = new Kurs(this.Name);
            tmp.STnm = this.STnm;
            tmp.MR = this.MR;
            return tmp;
        }

        public int CompareTo(Kurs other)
        {
            int cmp =   Name.CompareTo(other.Name);

            if (cmp == 0) return TD_L.CompareTo(other.TD_L);
            else
                return cmp;
        }
    }
}
