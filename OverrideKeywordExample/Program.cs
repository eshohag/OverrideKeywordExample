using System;

namespace OverrideKeywordExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee1 = new DevEmployee("Alice",1000);
            Console.WriteLine(employee1.CalculatePay());

            var employee2 = new EngineerEmployee("Arif",1000);
            Console.WriteLine(employee2.CalculatePay());

            Console.ReadKey();
        }
    }
}
