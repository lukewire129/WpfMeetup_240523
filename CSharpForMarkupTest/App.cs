using CSharpMarkup.WPF.Support;
namespace CSharpForMarkupTest;

public class App : MarkupApplication
{
    public App()
    {
        MainWindow = new AppWindow ();
    }
}