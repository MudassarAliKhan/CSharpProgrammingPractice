using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    internal class CSharp53Reflection
    {
        //public static void Main()
        //{
        //    Type T = Type.GetType("CSharpProgrammingPractice.Reflection");
        //    Console.WriteLine(T.Namespace);
        //    Console.WriteLine(T.Name);
        //    Console.WriteLine(T.FullName);
        //    Console.WriteLine(T.AssemblyQualifiedName);
        //    Console.WriteLine(T.Assembly);
        //    Console.WriteLine(T.Assembly.GetName().Version.ToString());
        //    Console.WriteLine(T.Assembly.GetName().Name);
        //    Console.WriteLine(T.Assembly.GetName().CodeBase);
        //    PropertyInfo[] propertyInfos = T.GetProperties();
        //    foreach (PropertyInfo propertyInfo in propertyInfos)
        //    {
        //        Console.WriteLine(propertyInfo.PropertyType.Name,propertyInfo.GetType().Name);
        //    }
        //    MethodInfo[] methodInfos = T.GetMethods();
        //    foreach (MethodInfo methodInfo in methodInfos)
        //    {
        //        Console.WriteLine("Method Name : "+methodInfo.Name+"Method Return Type:  "+methodInfo.ReturnType.Name);
        //    }
        //}
    }
    class Reflection
    {
        public int MyProperty { get; set; }
        public string MyString { get; set; }

        public void Prop()
        {
            MyProperty = 0;
        }
        public int MyEnum { get; set; }


    }
}
