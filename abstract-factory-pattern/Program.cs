// See https://aka.ms/new-console-template for more information
using abstract_factory_pattern.Application;
using abstract_factory_pattern.Factory;
using abstract_factory_pattern.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Approach 1
        IUIFactory darkfactory = new DarkThemeFactory();
        var appDark = new Application(darkfactory);
        appDark.RenderUI();

        IUIFactory lightFactory = new LightThemeFactory();
        var appLight = new Application(lightFactory);
        appLight.RenderUI();

        // Approach 2
        using var host = CreateHostBuilder(args).Build();
        var app = host.Services.GetRequiredService<Application>();
        app.RenderUI();
    }

    static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                string theme = "dark";

                if (theme == "dark")
                    services.AddSingleton<IUIFactory, DarkThemeFactory>();
                else
                    services.AddSingleton<IUIFactory, LightThemeFactory>();

                services.AddSingleton<Application>();
            });
    }
}