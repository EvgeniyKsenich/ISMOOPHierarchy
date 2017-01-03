using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class FACULT
    {
        Kurs_Archive arh = new Kurs_Archive();
        Teatcher[] tet = new Teatcher[0];
        Student[] sd = new Student[0];

        public FACULT()
        {
            tet = new Teatcher[2];
            tet[0]= new Teatcher("TET","One");
            tet[1] = new Teatcher("TET", "Two");

            sd = new Student[2];
            sd[0] = new Student("SD", "One");
            sd[1] = new Student("SD", "Two");
            tet[0].StartCourse("math");
            tet[0].PutOnCurs(0,0);
        }

        public void MENU()
        {
            while (true)
            {
                Console.WriteLine("1.Admin menu");
                Console.WriteLine("2.Teatcher menu");
                Console.WriteLine("3.Student menu");
                Console.WriteLine("4.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1) AdminMenu();
                if (c == 2)
                {
                    Console.WriteLine("Enter number");
                    int cq = int.Parse(Console.ReadLine());
                    Tetcher_Menu(cq);
                }
                if (c == 3)
                {
                    Console.WriteLine("Enter number");
                    int cq = int.Parse(Console.ReadLine());
                    Student_Menu(cq);
                }
                if (c == 4) break;
            }
        }

        protected void Student_Menu(int nm)
        {
            if (nm - 1 > -1 && nm - 1 < sd.Length)
            {
                while (true)
                {
                    Console.WriteLine("1.Put on curs");
                    Console.WriteLine("2.Exit");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        for(int i=0;i<tet.Length;i++)
                        {
                            Console.WriteLine((i+1) +")" +tet[i].Name + " " + tet[i].Surname);
                        }
                        Console.WriteLine("Enter teatcher num");
                        int cq = int.Parse(Console.ReadLine());
                        if (cq - 1 > -1 && cq - 1 < tet.Length)
                        {
                            Console.WriteLine("Enter course num");
                            tet[nm - 1].Prindourse();
                            int csq = int.Parse(Console.ReadLine());
                            tet[nm - 1].PutOnCurs(csq, nm);
                        }
                    }
                    if (c == 2) break;
                }
            }
            else Console.WriteLine("No such student");
        }

        protected virtual void Tetcher_Menu(int nm)
        {
            if (nm - 1 > -1 && nm - 1 < tet.Length)
            {
                while (true)
                {
                    Console.WriteLine("1.Start course");
                    Console.WriteLine("2.Stop course");
                    Console.WriteLine("3.Print");
                    Console.WriteLine("4.Exit");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        Console.WriteLine("Course name");
                        string cq = (Console.ReadLine());
                        tet[nm-1].StartCourse(cq);
                    }
                    if (c == 2)
                    {
                        Console.WriteLine("Number of curs:");
                        int cq = int.Parse(Console.ReadLine());
                        tet[nm - 1].StopCourse(cq);
                    }
                    if (c == 3)
                        tet[nm - 1].Print();
                    if (c == 4) break;
                }
            }
            else Console.WriteLine("No such teatcher");
        }

        protected void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("1.Add teatcher");
                Console.WriteLine("2.Add student");
                Console.WriteLine("3.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1) {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Surname");
                    string surname = Console.ReadLine();
                    Add_teatcher(name, surname);
                };
                if (c == 2)
                {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Surname");
                    string surname = Console.ReadLine();
                    Add_teatcher(name, surname);
                }
                if (c == 3) break;
            }
        }
        protected void Add_student(string name, string surname)
        {
            Student[] tmp_t = sd;
            sd = new Student[sd.Length + 1];
            CopyToMain(tmp_t);
            sd[sd.Length - 1] = new Student(name, surname);
        }
        protected void Add_teatcher(string name, string surname)
        {
            Teatcher[] tmp_t = tet;
            tet = new Teatcher[tet.Length + 1];
            CopyToMain(tmp_t);
            tet[tet.Length - 1] = new Teatcher(name, surname);
        }
        private void CopyToMain(Student[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                sd[i] = tmp[i];

            }
        }
        private void CopyToMain(Teatcher[] tmp)
        {
            int lic = tmp.Length;
            for (int i = 0; i < lic; i++)
            {
                tet[i] = tmp[i];

            }
        }

    }
}
