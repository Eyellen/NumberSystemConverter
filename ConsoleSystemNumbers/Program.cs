using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryNumberSystems;

namespace ConsoleNumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberSystems.ToDecimalSystem("AB321", 13));
            //Console.WriteLine(NumberSystems.toCustomSystem_str("1414,151516", 16));
        }
    }
}
