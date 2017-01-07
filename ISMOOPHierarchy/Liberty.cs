using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Liberty
    {
        Reader[] red = new Reader[0];
        Kurs[] books = new Kurs[0];
        Lib lib = new Lib("l", "l");

        public Liberty()
        {
            red = new Reader[1];
            red[0] = new Reader("r", "r");
            books = new Kurs[3];
            books[0] = new Kurs("Carols", true);
            books[1] = new Kurs("Miami", true);
            books[2] = new Kurs("Storm", true);
        }

        public void MUNE()
        {
            while (true)
            {
                Console.WriteLine("1.Liberyary menu");
                Console.WriteLine("2.Reader menu");
                Console.WriteLine("3.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1) L_menu();
                if (c == 2) R_menu();
                if (c == 3) break;
            }
        }
        public void R_menu()
        {
            Console.WriteLine("Enter num of user");
            int nm = int.Parse(Console.ReadLine());
            if (nm - 1 > -1 && nm - 1 < red.Length)
            {
                while (true)
                {
                    Console.WriteLine("1.Take");
                    Console.WriteLine("2.Exit");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        if (!lib.isBlocked(nm - 1))
                        {
                            Console.WriteLine("Enter book id");
                            int cz = int.Parse(Console.ReadLine());
                            red[nm - 1].AddInBook(cz-1);
                            books[cz - 1].Here = false;
                        }
                        else Console.WriteLine("Sorry you are at the black list");
                    }
                    if (c == 2) break;
                }
            }
        }

        public void L_menu()
        {
            while (true)
            {
                Console.WriteLine("1.Block");
                Console.WriteLine("2.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("Enter num of blocking user");
                    int cz = int.Parse(Console.ReadLine());
                    lib.AddInBlock(cz-1);
                }
                if (c == 2) break;
            }
        }
    }
}
