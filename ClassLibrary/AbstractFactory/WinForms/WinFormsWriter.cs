using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.AbstractFactory.WinForms
{
    internal class WinFormsWriter : IWriter
    {
        protected Label label;
        public WinFormsWriter(Label label)
        {
            this.label = label;
        }
        public void WriteDouble(double value, string message = null)
        {
            if (message != null)
            {
                label.Text = message + ":" + value.ToString();
            } else
            label.Text = value.ToString();
        }

        public void WriteInt(int value, string message = null)
        {
            if (message != null)
            {
                label.Text = message + ":" + value.ToString();
            }
            else
                label.Text = value.ToString();
        }

        public void WriteString(string value, string message = null)
        {
            if (message != null)
            {
                label.Text = message + ":" + value.ToString();
            }
            else
                label.Text = value.ToString();
        }
    }
}
