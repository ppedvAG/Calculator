using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;
namespace Calculator
{
    class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            var parser = new Parser();
            //var calc = new ModularCalculator(new Add(), new Multiplication());
            new ConsoleUI(parser,calc).Start();
        }
    }
}
