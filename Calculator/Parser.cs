using System;
using Calculator.Models;
namespace Calculator
{
    public class Parser : IParser
    {
        public Formula Parse(string input)
        {
            Formula f = new Formula();
            // Parse
            string[] splitInput = input.Split();
            f.Value1 = Convert.ToInt32(splitInput[0]);
            f.Value2 = Convert.ToInt32(splitInput[2]);
            f.Operator = splitInput[1][0];

            return f;
        }
    }
}
