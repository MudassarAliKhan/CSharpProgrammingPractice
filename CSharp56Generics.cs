using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    internal class CSharp56Generics
    {
        //public static void Main()
        //{
        //    bool equal = Generics.AreEqual<int>(10, 20);
        //     if (equal)
        //     {
        //        Console.WriteLine("Equal");
        //     }
        //     else
        //    {
        //        Console.WriteLine("Not Equal");
        //    }
        //}
    }
    public static class Generics
    {
        public static bool AreEqual<T>(T A , T B)
        {
            return A.Equals(B);
        }
    }
}
