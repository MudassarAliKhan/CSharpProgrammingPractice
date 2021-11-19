using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class Polymorphism
    {
        public string FirstName = "Mudassar";
        public string LastName = "Ali";
        

        public virtual void PrintInfo()
        {
            Console.WriteLine("Info"+FirstName+""+LastName+"Parent Class Method");
        }
    }
    public class PolymorphismChild : Polymorphism
    {
        
        public override void PrintInfo()
        {
            Console.WriteLine("Info" + FirstName + "" + LastName+"Polymorphsim Child Method");
        }
    }

}
