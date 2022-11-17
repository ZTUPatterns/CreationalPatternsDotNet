using WinFormsApp1.Components;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string? name = Core.Instance.LoadDataFromFile();
            if (name != null)
                labelRegisterTo.Text = name;
            else
                labelRegisterTo.Text = "(νεμΰΊ λ³φενη³Ώ)";
        }
        public void AddOwnComponentToForm(ComponentCreator creator)
        {
            var component = creator.Generate();           
            flowLayoutPanelMain.Controls.Add(component);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddOwnComponentToForm(new ComponentLoginCreator());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOwnComponentToForm(new ComponentMessageCreator());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddOwnComponentToForm(new ComponentInfoCreator());
        }
    }
}