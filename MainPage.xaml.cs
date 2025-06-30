using Microsoft.Maui.Controls;

namespace CICMmauiApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();


        //private void OnCounterClicked(object sender, EventArgs e, SemanticScreenReader semanticScreenReader)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";
        //    semanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

    public object CounterBtn { get; private set; }
}