using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    class Class2Strings
    {
        string fName = "Sardar Mudassar Ali";

        public void ConcatOpration()
        {
            string lName = "Khan";
            Console.WriteLine(String.Concat(fName,lName));
        }
        public void IntoInterpolation()
        {
            String FullName = "Sardar Mudassar Ali Khan";
            String Name = $"My Full Name is {FullName}";
            Console.WriteLine(Name);
        }
        public void AccessStrings()
        {
            Console.WriteLine(fName[0]);
            Console.WriteLine(fName.IndexOf('S'));
        }
        public void SubString()
        {
            int a = fName.IndexOf('s');
            String result = fName.Substring(a);
            Console.WriteLine(result);
        }
    }
}
