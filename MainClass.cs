using System;
using System.Collections.Generic;

namespace CSharpProgrammingPractice
{
    class MainClass
    {
        /*static void Main(string[] args)
        {
            *//*Console.WriteLine("--------------------------------------------------------");
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
            /*LinkQueryIncSharp linkQueryIncSharp = new LinkQueryIncSharp();
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
            arraysInCSHARP.main();*//*

            //PolymorphismChild polymorphismChild = new PolymorphismChild();
            *//*Polymorphism[] polymorphisms = new Polymorphism[4];
            polymorphisms[0] = new Polymorphism();
            polymorphisms[1] = new PolymorphismChild();

            foreach (Polymorphism item in polymorphisms)
            {
                item.PrintInfo();
            }*/

            /*MethodOverRidingVsMethodHiding m = new B1();
            m.M1();
            MethodOverLoading methodOverLoading = new MethodOverLoading();
            methodOverLoading.MethodA(2, 3);
            methodOverLoading.MethodA(2.3f,2.3f,2.5f);
            DelegatesInCsharp delegatesInCsharp = new DelegatesInCsharp();
            Delegate programmingPracticeEventHandler = new Delegate(delegatesInCsharp.Hello);
            programmingPracticeEventHandler("Delegates in CSharp Basic");*//*
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(){Id = 1, Name ="Mudassar", PhoneNo =45, Salary=50000});
            list.Add(new Employee() { Id = 2, Name = "Asad", PhoneNo = 46, Salary = 150000 });
            list.Add(new Employee() { Id = 3, Name = "Mubashir", PhoneNo = 47, Salary = 160000 });
            list.Add(new Employee() { Id = 4, Name = "Muzhar", PhoneNo = 48, Salary = 200000 });

           // IsPromotable isPromotable = new IsPromotable(IsPromotableEmployee);
            

             bool IsPromotableEmployee(Employee emp)
            {
                if(emp.Salary>50000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Employee employee = new Employee();
            Employee.EmployeeList(list, emp => emp.Salary>50000);




        }*/

    }
}
