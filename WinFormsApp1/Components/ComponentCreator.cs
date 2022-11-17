using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Components
{
    public abstract class ComponentCreator
    {
        protected abstract ICompomentElement ComponentCreate();
        public FlowLayoutPanel Generate()
        {
            var component = ComponentCreate().Build();
            component.AutoSize = true;
            component.BackColor = Color.White;
            return component;
        }
    }
}
