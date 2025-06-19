using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_pattern.Interface
{
    public interface IUIFactory
    {
        public IButton CreateButton();
        public ITextBox CreateTextBox();
    }
}
