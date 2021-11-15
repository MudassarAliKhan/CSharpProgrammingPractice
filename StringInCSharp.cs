using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class StringInCSharp
    {
        static string ststic = "Static";
        public void StringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Mudassar");
            stringBuilder.Replace('M', 'N');
            stringBuilder.AppendFormat("#CNDCNDJ&788", stringBuilder);
            stringBuilder.AppendLine("Sardar Mudassare Alinkahan");
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                Console.WriteLine(stringBuilder);
            }
        }
        public void ArrayList()
        {
            List<string> str = new List<string>()
            {
                "Sardar Ali Khan",
                "Sardar Mudassar Ali Khan",
                "Sardar Mubashir Ali Khan"
            };
            var result = from s in str
                         where s.Contains("M")
                         select s;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
                         


        }
        public void TurneryOperator()
        {
            string name = "Mudi";
            var name1 = name.Equals("Mudi") ? "Asad" : "Asad Ali";
            Console.WriteLine(name1);
        }

        public static void run()
        {
            ststic = "Static Mudassar";
            Console.WriteLine("Mudassar Ali Khan"+ ststic);
        }


    }
}
