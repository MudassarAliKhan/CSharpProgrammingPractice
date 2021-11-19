using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    internal class CSharp55LateTimeBinding
    {
        //#region Importent
        //public static void Main()
        //{
        //    Assembly executingAssembly = Assembly.GetExecutingAssembly();
        //    Type LateTimeBindingType = executingAssembly.GetType("CSharpProgrammingPractice.LateTimeBinding");
        //    Object LateTimeBindingInstance = Activator.CreateInstance(LateTimeBindingType);
        //    MethodInfo methodInfo = LateTimeBindingType.GetMethod("GetFullName");

        //    String[] str = new String[2];
        //    str[0] = "Mudassar Ali Khan";
        //    str[1] = "Sardar";
        //    String MethodiNFO = (String)methodInfo.Invoke(LateTimeBindingInstance, str);
        //    Console.WriteLine(MethodiNFO);


        //}
        //#endregion
    }
    public class LateTimeBinding
    {
        public string GetFullName(string Fname, String Lname)
        {
            return Fname + "" + Lname;
        }
    }
}
