// See https://aka.ms/new-console-template for more information
using factory_design_pattern.Constants;
using factory_design_pattern.Factory;
using factory_design_pattern.Interface;

Console.WriteLine("Hello, World!");

INotification notification = NotificationFactory.GetNotification(CNotificationTypes.EmailNotification);
notification.Notify("Welcome to Factory Pattern in C#!");

INotification sms = NotificationFactory.GetNotification(CNotificationTypes.SMSNotification);
sms.Notify("OTP: 123456");
