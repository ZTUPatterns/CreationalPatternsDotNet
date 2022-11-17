using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Components
{
    public class ComponentInfo : ICompomentElement
    {
        public FlowLayoutPanel Build()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            Label label = new Label();
            label.Text = "Інформація";
            label.AutoSize = true;        
            flowLayoutPanel.Controls.Add(label);
            return flowLayoutPanel;
        }
    }
}
