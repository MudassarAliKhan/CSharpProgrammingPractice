using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public delegate void Delegate(String Name);

    public class DelegatesInCsharp
    {
        public void Hello(String Message)
        {
            Console.WriteLine("Delegate Message  "+Message);
        }
    }
}
