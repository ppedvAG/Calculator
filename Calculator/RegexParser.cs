using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class RegexParser : IParser
    {
        public Formula Parse(string input)
        {
            Regex r = new Regex(@"(\d+)\s*(\D+)\s*(\d+)");
            var result = r.Match(input);

            if(result.Success)
            {
                Formula output = new Formula();
                output.Value1 = Convert.ToInt32(result.Groups[1].Value);
                output.Operator = result.Groups[2].Value[0];
                output.Value2 = Convert.ToInt32(result.Groups[3].Value);
                return output;
            }
            throw new FormatException("Input is not a valid formula");
        }
    }
}
