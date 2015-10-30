using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        private int salary;
        private int basesalary;
        private int benefit;

        public int BaseSalary
        {
            get { return basesalary; }
            set { if (value < 0) value = 0; else if (value > 100000) value = 100000; basesalary = value; }
        }


        public int Benefit
        {
            get { return benefit; }
            set { if (value < 0) value = 0; else if (value > 50000) value = 50000; benefit = value; }
        }

        public int Salary
        {
            get { return basesalary + benefit; }
            set { salary = value; }
        }



        private string firstName;
        private string lastName;

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }


        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


    }
}
