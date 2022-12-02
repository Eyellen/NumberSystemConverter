using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberSystems;

namespace ConsoleNumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(NumberSystems.ToDecimalSystem("17,435", 8));
            //Console.WriteLine(NumberSystems.ToCustomSystem("17,435", 8));

            //Dynamsys dynamsys = new Dynamsys("00000.AGFI6", 19);
            //Console.WriteLine(dynamsys.ToString());

            ////dynamsys = new Dynamsys(".AGFI6", 19);
            ////Console.WriteLine(dynamsys.ToString());

            //dynamsys = new Dynamsys("AGFI6", 19);
            //Console.WriteLine(dynamsys.ToString());

            while (true)
            {
                string number = Console.ReadLine();

                Console.WriteLine(Dynamsys.IsNumber(number));
            }
        }
    }
}
