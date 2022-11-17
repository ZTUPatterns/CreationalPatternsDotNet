using ClassLibrary;
using ClassLibrary.AbstractFactory.WinForms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManipulator dataManipulator = 
                new DataManipulator(
                    new WinFormsAbstractFactory(textBox1, textBox2, label1));
            dataManipulator.DoCalculation();
        }
    }
}