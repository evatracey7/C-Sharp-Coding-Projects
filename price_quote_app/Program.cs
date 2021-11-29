using System;

namespace price_quote_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double dimensionProduct = (packageWidth * packageHeight * packageLength);
                    double outcome = (dimensionProduct * packageWeight);
                    double priceQuote = (outcome / 100);

                    Console.WriteLine("Your estimated total for shipping this package is: $" + priceQuote);
                    Console.WriteLine("Thank you");
                }
            }
        }
    }
}
