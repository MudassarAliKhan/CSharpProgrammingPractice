using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class Class8ForLoop
    {
        public Class8ForLoop()
        {
                
        }

        public void SimlpeForLoop(int a)
        {
            for(int i =0;i<15; i++)
            {
                int res = i+15;
                Console.WriteLine(res);
            }
        }

        public void ForLoopComplex(int[] arr)
        {
            Console.WriteLine("Array Complex");
            for(int i = 0; i<arr.Length;i++)
            {
                Console.WriteLine(arr);
            }

        }
    }
}
