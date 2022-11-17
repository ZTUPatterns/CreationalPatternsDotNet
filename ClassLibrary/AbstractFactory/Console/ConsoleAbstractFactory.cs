using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory
{
    public class ConsoleAbstractFactory : IAbstractFactory
    {
        public IReader CreateReader()
        {
            return new ConsoleReader();
        }

        public IWriter CreateWriter()
        {
            return new ConsoleWriter();
        }
    }
}
