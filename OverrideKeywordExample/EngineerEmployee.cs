using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideKeywordExample
{
    public class EngineerEmployee : Employee
    {
        public string name;
        private double salary;
        public EngineerEmployee(string name, double salary) : base(name, salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public override double CalculatePay()
        {
            return salary + salary * 0.2;
        }
    }
}
