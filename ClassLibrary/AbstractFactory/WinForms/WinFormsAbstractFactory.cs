using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.AbstractFactory.WinForms
{
    public class WinFormsAbstractFactory : IAbstractFactory
    {
        protected TextBox firstValueTextBox;
        protected TextBox secondValueTextBox;
        protected Label resultLabel;
        public WinFormsAbstractFactory(TextBox firstValueTextBox, 
            TextBox secondValueTextBox, 
            Label resultLabel)
        {
            this.secondValueTextBox = secondValueTextBox;
            this.firstValueTextBox = firstValueTextBox;
            this.resultLabel = resultLabel;
        }
        public IReader CreateReader()
        {
            return new WinFormsReader(firstValueTextBox, secondValueTextBox);
        }

        public IWriter CreateWriter()
        {
            return new WinFormsWriter(resultLabel);
        }
    }
}
