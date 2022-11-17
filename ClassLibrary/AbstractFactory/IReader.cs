using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory
{
    public interface IReader
    {
        int ReadInt();
        string ReadString();
        double ReadDouble();
    }
}
