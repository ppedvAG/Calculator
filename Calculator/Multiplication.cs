using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Multiplication : ICalculationOperation
    {
        public char Operator => '*';

        public int Calculate(int v1, int v2) => v1 * v2;
    }
}
