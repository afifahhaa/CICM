using Application = Microsoft.Maui.Controls.Application;
using CICMmauiApp.View;
using static CICMmauiApp.AppShell;
using Microsoft.Maui.Controls;

namespace CICMmauiApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new LoginPage());
        //MainPage = new NavigationPage(new IssuePage());
    }


    //Window CreateWindow(IActivationState activationState)
    //{
    //    MainPage = new MainPage();
    //    return base.CreateWindow(activationState);
    //}


    //private IWindow CreateWindow(IActivationState activationState)
    //{
    //    this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
    //        .SetImageDirectory("Assets");

    //    return new Window(new IssuePage());
    //}
}