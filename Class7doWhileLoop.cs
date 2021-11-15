using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class Class7doWhileLoop
    {
        public Class7doWhileLoop()
        {

        }
        public void dwhileloopsimple()
        {
            int i = 0;
            do
            {
                i = i + 2;
                Console.WriteLine(i);
            }
            while (i < 15);
        }
        public void doWhileLoopComplex(int[] array)
        {
            do
            {
                array[0] = array[0] + 2;
                Console.WriteLine("Array Elements Are" +array[0]);
               
            }
            while (array[0]<30);
        }
        public void doWhileLoopString(string[] arr)
        {
            do
            {
                Console.WriteLine(string.Join("", arr));
            }
            while (arr.Length <5);
            
        }


    }
}
