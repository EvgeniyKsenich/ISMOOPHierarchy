using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    static class Extension
    {
        public static void PrintName(this Book str)
        {
            Console.WriteLine(str.Name);
        }
        public static void PrintExistence(this Book str)
        {
            Console.WriteLine(str.Here);
        }

        public static void PrintCourseCount(this Teatcher str)
        {
            Console.WriteLine(str.LENTH_B);
        }
        public static void PrintName(this Teatcher str)
        {
            Console.WriteLine(str.Name);
        }
    }
}
