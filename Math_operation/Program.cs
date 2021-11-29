using System;

namespace Math_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to multiply it by 50");
            int numMultiply = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numMultiply * 50);

            Console.WriteLine("Enter a number to add it by 25");
            int numAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numAdd + 25);

            Console.WriteLine("Enter a number to divide it by 12.5");
            float numDivide = float.Parse(Console.ReadLine());
            Console.WriteLine(numDivide / 12.5);

            Console.WriteLine("Enter a number to check whether it is greater than 50");
            int numGreater = Convert.ToInt32(Console.ReadLine());
            bool numBool = numGreater > 50;
            Console.WriteLine(numBool);

            Console.WriteLine("Enter a number to check its remainder");
            int numRemainder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numRemainder % 7);
        }
    }
}
