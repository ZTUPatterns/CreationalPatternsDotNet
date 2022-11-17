using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory
{
    public class ConsoleReader : IReader
    {
        public double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        public int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
