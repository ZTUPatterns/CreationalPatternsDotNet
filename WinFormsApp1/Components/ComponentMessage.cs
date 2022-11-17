using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Components
{
    public class ComponentMessage : ICompomentElement
    {
        public FlowLayoutPanel Build()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            Label messageLabel = new Label();
            messageLabel.Text = "Текст повідомлення: ";
            messageLabel.AutoSize = true;
            TextBox messageTextbox = new TextBox();          
            flowLayoutPanel.Controls.Add(messageLabel);
            flowLayoutPanel.Controls.Add(messageTextbox);
            return flowLayoutPanel;
        }
    }
}
