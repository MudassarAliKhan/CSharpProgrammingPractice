using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class LinkQueryIncSharp
    {


     public void IlistMethod2()
    {
         string a = "Mudassar";
         string b = "Ali";
         string c = "Khan";
         string FullName = $"{a}{b}{c}";
            Console.WriteLine(FullName);
    }
    public void IlistMethod()
    {

        List<string> ilist = new List<string>()
            {
                "Mudassar Ali Khan",
                "Saradr Ali",
                "Khan"
            };
        var res = from s in ilist
                  where s.Contains("Sardar")
                  select s;

        foreach (var item in res)
        {
            Console.WriteLine(item);
        }

    }
}
}
