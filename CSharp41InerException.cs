using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class CSharp41InerException
    {
       /* public static void Main(String[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter Fisrt Number");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int b = int.Parse(Console.ReadLine());
                    int c = a / b;
                    Console.WriteLine("Result = " + c);
                }
                catch (Exception ex)
                {
                    String Filepath = @"F:\Data\Log1.txt";
                    if (File.Exists(Filepath))
                    {
                        StreamWriter streamWriter = new StreamWriter(Filepath);
                        streamWriter.WriteLine(ex.GetType().Name);
                        streamWriter.WriteLine();
                        streamWriter.WriteLine(ex.Message);
                        streamWriter.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException(Filepath + "File Not Found", ex);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:  "+ex.GetType().Name);
                if(ex.InnerException!=null)
                {
                    Console.WriteLine("Inner Exception is : = {0}"+ex.InnerException.Message);
                    Console.WriteLine("Inner Exception is : = {0}"+ex.InnerException.GetType().Name);
                }
             
            }
        }*/
    }
}
