using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory.File
{
    public class FileWriter : IWriter, IDisposable
    {
        protected string fileName;
        protected StreamWriter streamWriter;
        public FileWriter(string fileName)
        {
            this.fileName = fileName;
            streamWriter = new StreamWriter(fileName);
        }
        public void Dispose()
        {
            streamWriter.Close();
            streamWriter.Dispose();
        }

        public void WriteDouble(double value, string message = null)
        {
            if (message != null)
                streamWriter.Write(message);
            streamWriter.WriteLine(value);
        }

        public void WriteInt(int value, string message = null)
        {
            if (message != null)
                streamWriter.Write(message);
            streamWriter.WriteLine(value);
        }

        public void WriteString(string value, string message = null)
        {
            if (message != null)
                streamWriter.Write(message);
            streamWriter.WriteLine(value);
        }
    }
}
