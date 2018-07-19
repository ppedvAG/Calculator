using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            foreach (string file in Directory.GetFiles(Path.Combine(Environment.CurrentDirectory,"PlugIns")))
                if(Path.GetExtension(file) == ".dll")
                    Assembly.LoadFile(file);

            var allTypesWhichImplementICalculationOperation = AppDomain.CurrentDomain.GetAssemblies()
                                                                       .SelectMany(assembly => assembly.GetTypes())
                                                                       .Where(x => typeof(ICalculationOperation).IsAssignableFrom(x) && x.IsInterface == false && x.IsAbstract == false)
                                                                       .ToArray();

            var parser = new RegexParser();
            var calc = new ModularCalculator( allTypesWhichImplementICalculationOperation.Select(x => (ICalculationOperation)Activator.CreateInstance(x)).ToArray() );
            new ConsoleUI(parser,calc).Start();
        }
    }
}
