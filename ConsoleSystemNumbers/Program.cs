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
            //Console.WriteLine(NumberSystems.toDecimalSystem_str("AB321", 16));
            Console.WriteLine(NumberSystems.toCustomSystem_str("1415135", 16));
        }
    }
}
