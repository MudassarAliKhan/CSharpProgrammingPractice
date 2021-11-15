using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class Class5SwitchStatement
    {
              
        public Class5SwitchStatement()
        {

        }
        public int input()
        {
            Console.WriteLine();
            return 0;
        }
        public void Switch(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                   int a = Console.Read();
                    Console.WriteLine(a);
                    break;
                default:
                    break;
            }
        }
    }
}
