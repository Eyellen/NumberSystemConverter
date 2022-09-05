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
            Console.WriteLine(NumberSystems.ToDecimalSystem("17,435", 8));
            //Console.WriteLine(NumberSystems.ToCustomSystem("17,435", 8));
        }
    }
}
