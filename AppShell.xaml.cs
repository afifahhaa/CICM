//using CICMmauiApp.view;

using CICMmauiApp.View;

namespace CICMmauiApp;

public partial class AppShell : Shell
{
    private object? routing;
    private NavigationPage MainPageWinRTTypeDetails;

    public object? Routing { get; private set; }

    public AppShell(NavigationPage mainPage) => this.MainPageWinRTTypeDetails = mainPage;

    public AppShell()
    {

        InitializeComponent();
        //Register all routes
        //object value = Routing.RegisterRoute("login", typeof(MainPage));
        //MainPageWinRTTypeDetails = new NavigationPage(new MainPage());
        //Routing.RegisterRoute("main", typeof(IssuePage));
        //Routing.RegisterRoute("issue", typeof(View.IssuePage));
        //Routing.RegisterRoute("newrequest", type: typeof(View.NewRequestPage));
        //Routing.RegisterRoute("viewsingleticket", type: typeof(View.ViewTicketPage));
        Routing = Routing ?? throw new ArgumentNullException(nameof(Routing));
        SetRouting(routing ?? throw new ArgumentNullException(nameof(routing)));
    }

    private void SetRouting(object value)
    {
        throw new NotImplementedException();
    }



    //private void SetRouting(Routing routing)
    //{
    //    throw new NotImplementedException();
    //}

    //public Routing GetRouting()
    //{
    //    return routing;
    //}

    //public override bool Equals(object? obj)
    //{
    //    return obj is AppShell shell &&
    //           EqualityComparer<Routing>.Default.Equals(routing, shell.routing);
    //}

    //public override int GetHashCode()
    //{
    //return HashCode.Combine(routing);
    //}

    internal class MainPage
    {
        private readonly Return? mainticket;
    }

}

internal class Return
{
}

public partial class BasicButtonClickPage : ContentPage
{
    public BasicButtonClickPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}

//    async void OnButtonClicked(object sender, EventArgs args)
//    {
//        await label.RelRotateTo(360, 1000);
//    }
//}