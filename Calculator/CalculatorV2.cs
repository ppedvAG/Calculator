using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ModularCalculator : ICalculator
    {
        public ModularCalculator(params ICalculationOperation[] operations)
        {
            this.operations = operations;
        }
        private readonly ICalculationOperation[] operations;

        public int Calculate(Formula f)
        {
            foreach (var item in operations)
            {
                if (item.Operator == f.Operator)
                    return item.Calculate(f.Value1, f.Value2);
            }
            throw new NotSupportedException("Operator not supported!");
        }
    }
}
