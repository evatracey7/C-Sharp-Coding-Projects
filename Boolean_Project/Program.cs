using System;

namespace Boolean_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? type [true/false]");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualify");
            bool qualify = (age >= 15 && DUI == "false" && speedingTickets <= 3);

            Console.WriteLine(qualify);
        }
    }
}
