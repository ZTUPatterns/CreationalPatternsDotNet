using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.AbstractFactory.WinForms
{
    public class WinFormsReader : IReader
    {
        protected TextBox textBox1;
        protected TextBox textBox2;
        public WinFormsReader(TextBox textBox1, TextBox textBox2)
        {
            this.textBox1 = textBox1;
            this.textBox2 = textBox2;
        }
        public double ReadDouble()
        {
            return double.Parse(textBox2.Text);
        }

        public int ReadInt()
        {
            return int.Parse(textBox1.Text);
        }

        public string ReadString()
        {
            throw new NotImplementedException();
        }
    }
}
