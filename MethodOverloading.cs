using System;

namespace MethodInC_
{
    internal class MethodOverloading
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            double x = 5, y = 10.5;

            Console.WriteLine("Sum of integers: " + Add(a, b));
            Console.WriteLine("Sum of doubles: " + Add(x, y));
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
