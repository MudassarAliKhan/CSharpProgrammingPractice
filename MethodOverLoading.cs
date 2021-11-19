using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class MethodOverLoading
    {
        public void MethodA(int a , int b)
        {
            Console.WriteLine("Method 1");
        }
        public void MethodA(float a, float b, float c)
        {
            Console.WriteLine("Method 1");
        }
    }
}
