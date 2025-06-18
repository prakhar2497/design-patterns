// See https://aka.ms/new-console-template for more information
using factory_design_patterm.Factory;
using factory_design_pattern.Constants;
using factory_design_pattern.Factory;
using factory_design_pattern.Interface;

Console.WriteLine("Hello, World!");


// Approach 1
INotification notification = NotificationFactory.GetNotification(CNotificationTypes.EmailNotification);
notification.Notify("Welcome to Factory Pattern in C#!");

INotification sms = NotificationFactory.GetNotification(CNotificationTypes.SMSNotification);
sms.Notify("OTP: 123456");

// Approach 2
INotification notification2 = NotificationFactory2.GetNotification(CNotificationTypes.EmailNotification);
notification2.Notify("Welcome to Factory Pattern in C#!");

INotification sms2 = NotificationFactory2.GetNotification(CNotificationTypes.SMSNotification);
sms2.Notify("OTP: 123456");
