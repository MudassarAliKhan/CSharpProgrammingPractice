using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    internal class CSharp52Attributes
    {
        //public static void Main()
        //{
        //    MyClass.Add(10, 12);
        //    List<int> list = new List<int>();
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);
        //    list.Add(4);
        //    list.Add(5);
        //    list.Add(6);
        //    list.Add(7);
        //    list.Add(8);
        //    list.Add(9);
        //    list.Add(10);
        //    list.Add(11);
        //    Console.WriteLine(MyClass.Add(list));
        //}
    }
    public static class MyClass
    {
        [Obsolete("Use Add Add(List<int> list) Numbers")]
        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Result is :" + c);
        }
        public static int Add(List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum = sum + item;
            }
            return sum;
            Console.WriteLine("Sum is :"+sum);
        }
    }
}
