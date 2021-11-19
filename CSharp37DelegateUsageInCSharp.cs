using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{

    public delegate bool IsPromotable(Employee employee);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNo { get; set; }
        public int Salary { get; set; }

        public static void EmployeeList(List<Employee> emplist, IsPromotable isPromotable)
        {
            foreach (Employee emp in emplist)
            {
                if (isPromotable(emp))
                {
                    Console.WriteLine(emp.Name + ": Promoted");
                }
            }
        }
       /* static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = 1, Name = "Mudassar", PhoneNo = 45, Salary = 50000 });
            list.Add(new Employee() { Id = 2, Name = "Asad", PhoneNo = 46, Salary = 150000 });
            list.Add(new Employee() { Id = 3, Name = "Mubashir", PhoneNo = 47, Salary = 160000 });
            list.Add(new Employee() { Id = 4, Name = "Muzhar", PhoneNo = 48, Salary = 200000 });

            // IsPromotable isPromotable = new IsPromotable(IsPromotableEmployee);


            bool IsPromotableEmployee(Employee emp)
            {
                if (emp.Salary > 50000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Employee employee = new Employee();
            Employee.EmployeeList(list, emp => emp.Salary > 50000);



        }*/
    }

}
