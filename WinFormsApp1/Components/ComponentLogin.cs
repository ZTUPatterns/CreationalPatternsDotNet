using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Components
{
    public class ComponentLogin : ICompomentElement
    {
        public FlowLayoutPanel Build()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();       
            Label loginLabel = new Label();
            loginLabel.Text = "Логін: ";
            loginLabel.AutoSize = true;
            TextBox loginTextbox = new TextBox(); 
            Label passLabel = new Label();
            passLabel.Text = "Пароль: ";
            passLabel.AutoSize = true;
            TextBox passTextbox = new TextBox();
            flowLayoutPanel.Controls.Add(loginLabel);
            flowLayoutPanel.Controls.Add(loginTextbox);
            flowLayoutPanel.Controls.Add(passLabel);
            flowLayoutPanel.Controls.Add(passTextbox);     
            return flowLayoutPanel;
        }
    }
}
