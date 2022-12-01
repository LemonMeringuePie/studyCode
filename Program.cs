using System;

namespace testMetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number one");
            double numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number one");
            double numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(divideAndRound(numberOne, numberTwo));
            Console.ReadLine();
        }
        static int divideAndRound(double a, double b)
        {
            return (int)Math.Round(a / b);
        }
    }
}
