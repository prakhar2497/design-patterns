// See https://aka.ms/new-console-template for more information
using abstract_factory_pattern.Application;
using abstract_factory_pattern.Factory;
using abstract_factory_pattern.Interface;

Console.WriteLine("Hello, World!");

IUIFactory darkfactory = new DarkThemeFactory();
var appDark = new Application(darkfactory);
appDark.RenderUI();

IUIFactory lightFactory = new LightThemeFactory();
var appLight = new Application(lightFactory);
appLight.RenderUI();