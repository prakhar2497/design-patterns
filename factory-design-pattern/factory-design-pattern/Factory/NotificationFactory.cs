using factory_design_pattern.Constants;
using factory_design_pattern.Interface;
using factory_design_pattern.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_design_pattern.Factory
{
    public class NotificationFactory
    {
        public static INotification GetNotification(string type)
        {
            switch (type)
            {
                case CNotificationTypes.EmailNotification:
                    return new EmailNotification();
                case CNotificationTypes.SMSNotification:
                    return new SMSNotification();
                default:
                    throw new ArgumentException("Invalid Notification Type.");
            }
        }
    }
}
