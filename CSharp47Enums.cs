using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    internal class CSharp47Enums
    {
        /*public static void Main(String[] args)
        {
            short[] vs = (short[])(Enum.GetValues(typeof(myenum)));
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            string[] vs1 = Enum.GetNames(typeof(myenum));
            foreach (var item in vs1)
            {
                Console.WriteLine(item);
            }
        }*/
    }
}
#region Enums
public enum myenum :short
{
    Male = 1,
    Femail =2,
    UnKnown =3,
}
#endregion