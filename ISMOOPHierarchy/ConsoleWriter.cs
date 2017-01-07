using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    static class ConsoleWriter
    {
        public static void AddPrint(this Human str)
        {
            Console.WriteLine("Name:" + str.Name);
            Console.WriteLine("Surname:" + str.Surname);
        }
        public static void AddPrint(this Student str)
        {
            Console.WriteLine("Name:" + str.Name);
            Console.WriteLine("Surname:" + str.Surname);
        }
        public static void AddPrint(this Doctor str)
        {
            Console.WriteLine("Name:" + str.Name);
            Console.WriteLine("Surname:" + str.Surname);
        }
        public static void AddPrint(this Illnes str)
        {
            Console.WriteLine("Name:" + str.Name);
            Console.WriteLine("Surname:" + str.Surname);
        }
        public static void AddPrint(this Kurs str)
        {
            Console.WriteLine("Name:" + str.Name);
            string oout;
            if (str.Here == true)
                oout = "true";
            else oout = "false";
            Console.WriteLine("Is here:" + oout);
        }
        public static void AddPrint(this Reader str)
        {
            Console.WriteLine("Name:" + str.Name);
            Console.WriteLine("Surname:" + str.Surname);
        }
        public static void AddPrint(this Teatcher str)
        {
            str.Print();
        }
    }
}
