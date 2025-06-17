using factory_design_pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_design_pattern.Module
{
    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine("This is Email: {0}", message);
        }
    }
}
