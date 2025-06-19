using abstract_factory_pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_pattern.Products
{
    public class DarkTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Dark Textbox");
        }
    }
}
