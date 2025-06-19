using abstract_factory_pattern.Interface;
using abstract_factory_pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_pattern.Factory
{
    public class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ITextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }
}
