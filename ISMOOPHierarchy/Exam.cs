using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Exam:FACULT
    {
        Student[] ab = new Student[0];
        Teatcher tt = new Teatcher("tt","tt");
        Kurs[] kurs= new Kurs[3];

        public Exam()
        {
            ab = new Student[1];
            
            ab[0] = new Student("one","one");

            //kurs[0] = new Kurs("math");
            //kurs[1] = new Kurs("ukr");
            //kurs[2] = new Kurs("ang");
            tt.StartCourse("math");
            tt.StartCourse("ang");
            tt.StartCourse("ukr");
            
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1.Teatcher menu");
                Console.WriteLine("2.Abiturient menu");
                Console.WriteLine("3.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1) Tetcher_Menu(0);
                if (c == 2) Ab_menu();
                if (c == 3) break;
            }
        }

        protected void Ab_menu()
        {
            while (true)
            {
                Console.WriteLine("1.Start exam");
                Console.WriteLine("2.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    tt.PutOnCurs(1, 0);
                    tt.PutOnCurs(2, 0);
                    tt.PutOnCurs(3, 0);
                }
                if (c == 2) break;
            }
        }

        protected override void Tetcher_Menu(int nm)
        {
            while (true)
            {
                Console.WriteLine("1.Stop exam");
                Console.WriteLine("2.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    tt.StopCourse(1);
                    tt.StopCourse(2);
                    tt.StopCourse(3);
                }
                if (c == 2) break;
            }
        }
    }
}
