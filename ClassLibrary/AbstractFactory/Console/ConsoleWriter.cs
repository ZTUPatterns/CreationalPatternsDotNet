using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory
{
    public class ConsoleWriter : IWriter
    {
        public void WriteDouble(double value, string message = null)
        {
            if (message != null)
                Console.Write(message);
            Console.WriteLine(value);
        }

        public void WriteInt(int value, string message = null)
        {
            if (message != null)
                Console.Write(message);
            Console.WriteLine(value);
        }

        public void WriteString(string value, string message = null)
        {
            if (message != null)
                Console.Write(message);
            Console.WriteLine(value);
        }
    }
}
