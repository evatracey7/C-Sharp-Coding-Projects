using System;

namespace income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            int p1HourlyRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int p1WorkingHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            int p2HourlyRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int p2WorkingHours = Convert.ToInt32(Console.ReadLine());

            int p1AnnualSalary = p1HourlyRate * p1WorkingHours * 52;
            int p2AnnualSalary = p2HourlyRate * p2WorkingHours * 52;

            Console.WriteLine("Annual Salary of person 1:");
            Console.WriteLine(p1AnnualSalary);

            Console.WriteLine("Annual Salary of person 2:");
            Console.WriteLine(p2AnnualSalary);

            Console.WriteLine("Person 1 makes more money than Person 2:");

            bool p1richer = (p1AnnualSalary > p2AnnualSalary);
            Console.WriteLine(Convert.ToString(p1richer));
        }
    }
}
