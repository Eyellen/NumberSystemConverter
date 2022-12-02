using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystems
{
    public class WrongNumberSystemException : Exception
    {
        public WrongNumberSystemException(string message) :
            base(message)
        { }
    }

    public class InappropriateCharactersException : Exception
    {
        public InappropriateCharactersException(string message) :
            base(message)
        { }
    }
}
