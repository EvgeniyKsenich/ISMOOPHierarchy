using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Hospital
    {
        Doctor[] doc = new Doctor[0];
        Illnes[] ill = new Illnes[0];

        public Hospital()
        {
            doc = new Doctor[2];
            ill = new Illnes[1];

            doc[0] = new Doctor("DOC", "ONE");
            doc[1] = new Doctor("DOC", "Two");

            ill[0] = new Illnes("illnes", "one");
        }

        public void MENU()
        {
            while (true)
            {
                Console.WriteLine("1.Doctor menu");
                Console.WriteLine("2.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1) Doctor_Menu();
                if (c == 2) break;
            }
        }
        public void Doctor_Menu()
        {
            Console.WriteLine("Chose doctor");
            int cz = int.Parse(Console.ReadLine());
            cz--;
            if (cz > -1 && cz < doc.Length)
            {
                while (true)
                {
                    Console.WriteLine("1.Add smt.");
                    Console.WriteLine("2.Do smt.");
                    Console.WriteLine("3.Exit");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        Console.WriteLine("What to add");
                        string doings = Console.ReadLine();
                        ill[0].AddInDoings(doings);
                        Console.WriteLine("Add");

                    }
                    if (c == 2)
                    {
                        Console.WriteLine("Enter num");
                        int cs = int.Parse(Console.ReadLine());
                        ill[0].DeleteFromMain(cs);
                        Console.WriteLine("Delete");

                    }
                    if (c == 3) break;
                }
            }
            else Console.WriteLine("No such doctor");
            
        }
    }
}
