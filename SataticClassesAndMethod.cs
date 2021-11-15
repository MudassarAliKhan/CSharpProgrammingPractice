using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public static class SataticClassesAndMethod
    {
        public static int a=10;
        public static int b=20;
        public static string name = "Sardar Mudassar Ali Khan";

        public static void Add()
        {
            int res = a + b;
            Console.WriteLine(res);
        }

        public static void substract()
        {
            int res = a - b;
            Console.WriteLine(res);
        }

    }
}
