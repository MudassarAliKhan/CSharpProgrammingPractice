using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class ArraysInCSHARP
    {
        public void main()
        {
            int[] a = new int[4];
            a[0] = 200;
            a[1] = 300;
            a[2] = 400;
            a[3] = 500;
            a[3] = 600;
           
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine("skjadjsbd");
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

    }
}
