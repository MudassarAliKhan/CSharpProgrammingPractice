using System;

namespace CSharpProgrammingPractice
{
    class MainClass
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Class C# Basics");
            Console.WriteLine("-------------------- Class 1 Math Operations In c#-----------------");
            //Math Operation in C#
            double a11 = 99.3;
            Class1MathLibraryInCsharp mathLibraryInCsharp = new Class1MathLibraryInCsharp();
            int a1 = mathLibraryInCsharp.a;
            int a2 = Convert.ToInt32(mathLibraryInCsharp.b);
            mathLibraryInCsharp.Mul(a1, a2);
            Console.WriteLine(Math.Sqrt(a1));
            Console.WriteLine(Math.Abs(a1));
            Console.WriteLine(Math.Round(a11));

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("------------------------Class 2 Strings In C#------------------------");
            //Strings in C#
            Class2Strings strings = new Class2Strings();
            strings.ConcatOpration();
            strings.IntoInterpolation();
            strings.AccessStrings();
            strings.SubString();

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------Class 3 Boolean in c#------------------------- ");
            Class3Boolean class3Boolean = new Class3Boolean();
            class3Boolean.Boolean();

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("---------------------------Class 5 Switch Statement in C#---------------------");
            Class5SwitchStatement class5SwitchStatement = new Class5SwitchStatement();
            Console.WriteLine("Enter the number");
            String a = Console.ReadLine();
            class5SwitchStatement.Switch(Convert.ToInt32(a));

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-----------------------Class 6 in While Loop-----------------------");
            Class6WhileLoopInCsharp class6WhileLoopInCsharp = new Class6WhileLoopInCsharp();
            Console.WriteLine("Enter the Input");
            String a3 = Console.ReadLine();
            Console.WriteLine("Loop Simple");
            class6WhileLoopInCsharp.WhileLoopSimple(Convert.ToInt32(a3));
            Console.WriteLine("Array Complex");
            int[] array = {0};
            class6WhileLoopInCsharp.WhileLoopMedium(array);

            Console.WriteLine("Array Hard");
            string[] array2 = {"Mudassar aLI","Khan","Software Engineer"};
            class6WhileLoopInCsharp.WhileLoopComplex(array2);

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("---------------CLASS 7-----------------");
            Class7doWhileLoop class7DoWhileLoop = new Class7doWhileLoop();
            class7DoWhileLoop.dwhileloopsimple();
            int[] arraydo = {0};
            class7DoWhileLoop.doWhileLoopComplex(arraydo);
            string[] arraystr = { "Sardar", "Mudassar", "Ali", "Khan" };
            // class7DoWhileLoop.doWhileLoopString(arraystr);

            Console.WriteLine("---------------------CLASS 8-------------------------------");
            Class8ForLoop class8ForLoop = new Class8ForLoop();
            class8ForLoop.SimlpeForLoop(15);
            int[] arr = {0};
            class8ForLoop.ForLoopComplex(arr);*/
            LinkQueryIncSharp linkQueryIncSharp = new LinkQueryIncSharp();
            linkQueryIncSharp.IlistMethod();
            linkQueryIncSharp.IlistMethod2();
            SataticClassesAndMethod.Add();
            StringInCSharp stringInCSharp = new StringInCSharp();
            stringInCSharp.ArrayList();
            stringInCSharp.StringBuilder();
            stringInCSharp.TurneryOperator();
            StringInCSharp.run();
            ExplicitandImplicitType explicitandImplicitType = new ExplicitandImplicitType();
            explicitandImplicitType.main();
            ArraysInCSHARP arraysInCSHARP = new ArraysInCSHARP();
            arraysInCSHARP.main();
        }

    }
}
