using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    
    public  class Class6WhileLoopInCsharp
    {
        public Class6WhileLoopInCsharp()
        {

        }

        public void WhileLoopSimple(int a)
        {
            while(a<7)
            {
                Console.WriteLine(a);
                a++;
            }
        }

        public void WhileLoopMedium(int[] a1) 
        {

            while (a1[0] < 15)
            {
                Console.WriteLine(a1[0]);
                a1[0]++;
            }
        }

        public void WhileLoopComplex(string[] a1)
        {

            while (a1.Length < 15)
            {
                a1.Append("Sardar Mudassar Ali khan");
                Console.WriteLine(String.Join("",a1));
                break;
            }
           
        }



    }

}
