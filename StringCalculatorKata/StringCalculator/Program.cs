using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers separated by a comma (,).");
            var numbers = Console.ReadLine();
            var calc = new Calculator();
            var result = calc.Add(numbers);
            Console.WriteLine("The sum of the entered numbers is {0}.", result);
        }
    }
}
