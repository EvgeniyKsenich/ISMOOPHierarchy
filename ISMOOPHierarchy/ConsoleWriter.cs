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
        public static void AddPrint(this Book str)
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
            Console.WriteLine("Course Count"+str.LENTH_B);
        }
        public static void AddPrint(this Teatcher str)
        {
            str.Print();
        }
        public static void AddPrint(this BANK_Administrator str)
        {
            str.Print();
        }
        public static void AddPrint(this BANK_Client str)
        {
            str.Print();
        }
        public static void AddPrint(this Kurs str)
        {
            Console.WriteLine(str.Name);
            str.Print();
        }
        public static void AddPrint(this Abiturient str)
        {
            str.Print();
        }
        public static void AddPrint(this Lib str)
        {
            str.Print();
            int[] bl = str.BL;
            for (int i = 0; i < bl.Length; i++)
                Console.Write(bl[i]+" ");
        }
        public static void AddPrint(this Kurs_Archive str)
        {
            Human[] hm = str.TET;
            Kurs[] rk = str.KR;
            for (int i = 0; i < hm.Length; i++)
            {
                hm[i].AddPrint();
                rk[i].AddPrint();
            }
        }
    }
}
