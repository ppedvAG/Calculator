using System;
using Calculator.Models;
namespace Calculator
{
    public class ConsoleUI
    {
        public ConsoleUI(IParser parser, ICalculator calculator)
        {
            this.parser = parser ?? throw new ArgumentNullException();
            this.calculator = calculator ?? throw new ArgumentNullException();
        }
        private readonly IParser parser;
        private readonly ICalculator calculator;

        public void Start()
        {
            // IO
            Console.WriteLine("Formula:");
            string input = Console.ReadLine(); // "2 + 2"

            Formula f = parser.Parse(input);
            int result = calculator.Calculate(f);

            // IO
            Console.WriteLine($"Result is: {result}");
            Console.WriteLine("---END---");
            Console.ReadKey();
        }
    }
}
