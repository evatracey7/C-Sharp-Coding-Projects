using System;

namespace loop_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 0;

            while (number >= 0)
            {
                do
                {
                    switch (number)
                    {
                        case 50:
                            Console.WriteLine("You entered 50.Try again");
                            Console.WriteLine("Guess the number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 100:
                            Console.WriteLine("You entered 100.Try again");
                            Console.WriteLine("Guess the number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("You neither entered 50 nor 100");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isGuessed);
            }
            Console.Read();
        }
    }
}
