using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpProgrammingPractice
{
    class Class1MathLibraryInCsharp
    {
        public int a = 88;
        public double b = 100;
        public Class1MathLibraryInCsharp()
        {
                
        }
        public Class1MathLibraryInCsharp( int a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void Mul(int a1, int b1)
        {
            a1 = a;
            b1 = Convert.ToInt32(b);
            int result = (a1*b1);
            Console.WriteLine(result);

        }
    }
}
