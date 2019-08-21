using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideKeywordExample
{
    public class Employee
    {
        public string name;
        private double salary;
        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual double CalculatePay()
        {
            return salary;
        }
    }
}
