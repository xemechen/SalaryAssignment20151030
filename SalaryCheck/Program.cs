using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace SalaryCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeLibrary.Employee employee = new EmployeeLibrary.Employee("Andrew", "Xeme");
            //Employee Andrew=new Employee("Andrew","Xeme");

            //Console.WriteLine("Input your First Name");
            //employee.FirstName = Console.ReadLine();
            //Console.WriteLine("Input your Last Name");
            //employee.LastName = Console.ReadLine();

            Console.WriteLine("Input your base salary (0-100,000)");
            string basesalary=Console.ReadLine();
            
            int bsalary; int benefi;
            Console.WriteLine("Input your benefit (0-50,000)");
            string benefit = Console.ReadLine();
            int.TryParse(basesalary, out bsalary);
            int.TryParse(benefit, out benefi);
            employee.Benefit=benefi;
            employee.BaseSalary=bsalary;
            Console.WriteLine(employee.FirstName+" "+employee.LastName+
                ", your total income is " + employee.Salary+".");

        }
    }
}
