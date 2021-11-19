using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class MethodOverRidingVsMethodHiding
    {
        public virtual void M1()
        {
            Console.WriteLine("Base Class Method");
        }
    }
    public class B1: MethodOverRidingVsMethodHiding
    {
        public override void M1()
        {
            Console.WriteLine("child Class Method");
        }
    }
}
