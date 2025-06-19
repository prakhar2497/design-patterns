using factory_design_pattern.Constants;
using factory_design_pattern.Interface;
using factory_design_pattern.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_design_patterm.Factory
{
    public static class NotificationFactory2
    {
        public static readonly Dictionary<string, Func<INotification>> _creators = new Dictionary<string, Func<INotification>>
        {
            { CNotificationTypes.EmailNotification, () => new EmailNotification() },
            { CNotificationTypes.SMSNotification, () => new SMSNotification() }
        };

        public static INotification GetNotification(string type)
        {
            if (_creators.TryGetValue(type, out var creator))
            {
                return creator();
            }

            throw new ArgumentException("Unsupported notification type");
        }

        public static void Register(string type, Func<INotification> creator)
        {
            _creators[type.ToUpper()] = creator;
        }
    }
}
