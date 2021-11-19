using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CSharpProgrammingPractice
{
    internal static class CSharp45Enums
    {
        
        public static int PromottedEmployee(int Salary)
        {
            if (Salary > 20000)
            {
                Console.WriteLine("Promotted");
            }
            else
            {
                return Salary;
            }
            return 0;
        }
    }
    public class Test2
    {
       

        //public static void Main(string[] args)
        //{
        //    Employee[] employee = new Employee[3];

        //    employee[0] = new Employee()
        //    {
        //        Id = 1,
        //        Name = "Mudassar",
        //        PhoneNo = 0125,
        //        Salary = 250000

        //    };
        //    employee[1] = new Employee()
        //    {
        //        Id = 1,
        //        Name = "Asad",
        //        PhoneNo = 0125,
        //        Salary = 250000

        //    }; employee[2] = new Employee()
        //    {
        //        Id = 1,
        //        Name = "Mubashir",
        //        PhoneNo = 0125,
        //        Salary = 250000

        //    };

        //    foreach (var item in employee)
        //    {
        //        Console.WriteLine("Promotted Employee:"+item.Name , CSharp45Enums.PromottedEmployee(item.Salary));
        //    }
        //}

    }
}

