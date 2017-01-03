using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class BANK
    {
        BANK_Client[] client = new BANK_Client[0];

        public void NewClient(string name, string surname, int num, double suma, double credit_cart)
        {
            BANK_Client[] tmp_client = client;
            client = new BANK_Client[client.Length+1];
            CopyToMain(tmp_client);
            client[client.Length-1] = new BANK_Client(name, surname, num, suma, credit_cart);
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1.Admin menu");
                Console.WriteLine("2.Client menu");
                Console.WriteLine("3.exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1) AdminMenu();
                if (c == 2) ClientMenu();
                if (c == 3) break;
            }
        }
        protected void ClientMenu()
        {
            int nm = int.Parse(Console.ReadLine());
            if (nm - 1 > -1 && nm - 1 < client.Length)
            {
                while (true)
                {
                    Console.WriteLine("1.Pay");
                    Console.WriteLine("2.Transaction");
                    Console.WriteLine("3.Block card");
                    Console.WriteLine("4.Block accaunt");
                    Console.WriteLine("5.Exit");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        Console.WriteLine("Suma");
                        double ssm = double.Parse(Console.ReadLine());
                        client[nm - 1].Pay(ssm);
                    }
                    if (c == 2)
                    {
                        Console.WriteLine("Suma");
                        double ssmw = double.Parse(Console.ReadLine());
                        Console.WriteLine("Transfer to");
                        int ssm = int.Parse(Console.ReadLine());
                        if (ssm - 1 > -1 && ssm - 1 < client.Length)
                        {
                            client[nm - 1].Pay(ssmw);
                            client[ssm - 1].Input(ssmw);
                        }
                        else Console.WriteLine("No such client");
                    }
                    if (c == 3)
                    {
                            client[nm - 1].AnulateCard();
                            Console.WriteLine("Anulated");
                    }
                    if (c == 4)
                    {
                        client[nm - 1].AnulateBank();
                        Console.WriteLine("Anulated");
                    }
                    if (c == 5) break;
                }
            }
            else
            {
                Console.WriteLine("1.No such client");
            }
        }

        protected void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("1.New client");
                Console.WriteLine("2.Search client");
                Console.WriteLine("3.Block card");
                Console.WriteLine("4.Exit");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Surname");
                    string surname = Console.ReadLine();
                    NewClient(name, surname, client.Length + 1, 0, 0);
                }

                if (c == 2)
                {
                    Console.WriteLine("Enter Number");
                    int nm = int.Parse(Console.ReadLine());
                    if (nm - 1 > -1 && nm - 1 < client.Length)
                    {
                        client[nm - 1].Print();
                    }
                    else Console.WriteLine("No such client");

                }
                if (c == 3)
                {
                    Console.WriteLine("Enter Number");
                    int nm = int.Parse(Console.ReadLine());
                    if (nm - 1 > -1 && nm - 1 < client.Length)
                    {
                        client[nm - 1].AnulateCard();
                        Console.WriteLine("Anulated");
                    }
                    else Console.WriteLine("No such client");
                }
                if (c == 4) break;
            }
        }

        private void CopyToMain(BANK_Client[] tmp)
        {
            int lic = tmp.Length;
            for(int i=0;i< lic;i++)
            {
                client[i] = tmp[i];
            }
        }
    }
}
