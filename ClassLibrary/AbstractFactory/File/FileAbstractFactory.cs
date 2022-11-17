using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory.File
{
    public class FileAbstractFactory : IAbstractFactory, IDisposable
    {
        protected string inputFileName;
        protected string outputFileName;
        protected IReader reader;
        protected IWriter writer;
        public FileAbstractFactory(string inputFileName, string outputFileName)
        {
            this.outputFileName = outputFileName;
            this.inputFileName = inputFileName;
        }
        public IReader CreateReader()
        {
            reader = new FileReader(inputFileName);
            return reader;
        }

        public IWriter CreateWriter()
        {
            writer = new FileWriter(outputFileName);
            return writer;
        }

        public void Dispose()
        {
            (reader as FileReader).Dispose();
            (writer as FileWriter).Dispose();
        }
    }
}
