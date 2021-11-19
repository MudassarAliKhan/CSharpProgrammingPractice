using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class CSharp43ExceptionAbuse
    {
        public void FindResult()
        {
            try
            {
                Console.WriteLine("Enter First Number");
                int numirator;
                bool Conversionsuccessfull = Int32.TryParse(Console.ReadLine(), out numirator);
                if (Conversionsuccessfull)
                {
                    Console.WriteLine("Enter secont Number");
                    int Denumirator;
                    bool ConversionDenumeratorsuccessfull = Int32.TryParse(Console.ReadLine(), out Denumirator);
                    if (ConversionDenumeratorsuccessfull && Denumirator != 0)
                    {
                        int c = numirator / Denumirator;
                        Console.WriteLine("Result =:" + c);
                    }
                    else
                    {
                        if (ConversionDenumeratorsuccessfull!=true && Denumirator==0)
                        {
                            Console.WriteLine("DeNumenator Cant be Zero rang is = {0},{1}" + Int32.MinValue + "To" + int.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numenator Cant be Zero rang is= {0},{1}"+Int32.MinValue +"To"+int.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caused by:"+ex.GetType().Name);
            }
        }
    }
    //public class Test2
    //{
    //    public static void Main(string[] args)
    //    {
    //        CSharp43ExceptionAbuse cSharp43ExceptionAbuse = new CSharp43ExceptionAbuse();
    //        cSharp43ExceptionAbuse.FindResult();
    //    }

    //}
}
