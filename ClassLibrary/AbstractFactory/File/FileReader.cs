using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary.AbstractFactory.File
{
    public class FileReader : IReader, IDisposable
    {
        protected string fileName;
        protected StreamReader streamReader;
        public FileReader(string fileName)
        {
            this.fileName = fileName;
            streamReader = new StreamReader(fileName);
        }

        public void Dispose()
        {
            streamReader.Close();
            streamReader.Dispose();
        }

        public double ReadDouble()
        {
            return double.Parse(streamReader.ReadLine());
        }

        public int ReadInt()
        {
            return int.Parse(streamReader.ReadLine());
        }

        public string ReadString()
        {
            return streamReader.ReadLine();
        }
    }
}
