using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            new ConsoleUI(new RegexParser(),new Calculator()).Start();
        }
    }

    public class Formula
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public char Operator { get; set; }
    }

    class ConsoleUI
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
