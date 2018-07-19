using System;
using Calculator.Models;
namespace Calculator
{
    public class Calculator : ICalculator
    {
        public int Calculate(Formula f)
        {
            if (f.Operator == '+')
                return f.Value1 + f.Value2;
            // else if .....

            throw new ArgumentException("Operator not supported");
        }
    }
}
