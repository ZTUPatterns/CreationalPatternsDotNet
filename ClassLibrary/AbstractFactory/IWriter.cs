using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory
{
    public interface IWriter
    {
        void WriteInt(int value, string message = null);
        void WriteString(string value, string message = null);
        void WriteDouble(double value, string message = null);
    }
}
