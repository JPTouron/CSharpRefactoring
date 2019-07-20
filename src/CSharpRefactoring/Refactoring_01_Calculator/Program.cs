using System;

namespace Refactoring_01_Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cd = new Calculator();

            var result = cd.Calculate((decimal)1000.5, 2, 5);

            Console.WriteLine($"resultado = {result}");

            Console.ReadLine();
        }
    }
}