using CSharpMarkup.WPF.Support;
using System.Windows;
namespace CSharpForMarkupTest;

public class App : MarkupApplication
{
    public App()
    {
        MainWindow = new AppWindow ();
    }
}