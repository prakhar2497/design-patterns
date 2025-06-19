using abstract_factory_pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_pattern.Application
{
    public  class Application
    {
        private readonly IButton _button;
        private readonly ITextBox _textBox;

        public Application(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _textBox = factory.CreateTextBox();
                
        }

        public void RenderUI()
        {
            _button.Render();
            _textBox.Render();
        }
    }
}
