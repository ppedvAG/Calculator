using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFeatures
{
    public class Add : ICalculationOperation
    {
        public char Operator => '+';

        public int Calculate(int v1, int v2) => v1 + v2;
    }
    public class Sub : ICalculationOperation
    {
        public char Operator => '-';

        public int Calculate(int v1, int v2) => v1 - v2;
    }
}
