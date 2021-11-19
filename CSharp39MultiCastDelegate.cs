using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public delegate void MulticastDelegate(out int variable);
    public class _39MultiCastDelegate
    {

        public static void FunctionOne(out int a)
        {
            Console.WriteLine("Delegate Invoke Function One");
            a = 1;
        }
        public static  void FunctionTwo(out int b)
        {
            Console.WriteLine("Delegate Invoke Function two");
            b = 2;
        }
        public static void FunctionThree(out int c)
        {
            Console.WriteLine("Delegate Invoke Function three");
            c = 3;
        }
        //public static void Main(String[] args)
        //{
        //    /* MulticastDelegate mcd1, mcd2, mcd3,mcd4;
        //     mcd2 = new MulticastDelegate(FunctionOne);
        //     mcd3 = new MulticastDelegate(FunctionTwo);
        //     mcd4 = new MulticastDelegate(FunctionThree);
        //     mcd1 = mcd2 + mcd3 - mcd4;
        //     mcd1();*/

        //    /*MulticastDelegate multicastDelegate = new MulticastDelegate(FunctionOne);
        //    multicastDelegate += FunctionTwo;
        //    multicastDelegate +=FunctionThree;
        //    multicastDelegate();*/
        //    MulticastDelegate multicastDelegate = new MulticastDelegate(FunctionOne);
        //    multicastDelegate += FunctionTwo;
        //    multicastDelegate += FunctionThree;
        //    int a = 1;
        //    multicastDelegate(out a);
        //    Console.WriteLine("Delegate Output Value =:"+a);


        //}
    }

    
}
