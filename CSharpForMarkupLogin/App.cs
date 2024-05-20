using CSharpForMarkupLogin.Views;
using CSharpMarkup.WPF.Support;
using System.Windows.Navigation;

namespace CSharpForMarkupLogin;

public class App : MarkupApplication
{
    NavigationWindow _navigationWindow;
    private LoginPage? loginPage;
    public App()
    {
        MainWindow = _navigationWindow = new NavigationWindow ()
        {
            Width = 360,
            Height = 590,
            ShowsNavigationUI = false,
            WindowStyle = System.Windows.WindowStyle.None,
            AllowsTransparency = true,
        };

        _navigationWindow.PreviewMouseDown += (s, e) =>
        {
            _navigationWindow.DragMove ();
        };

        Go (LoginPage);
    }


    MarkupPage LoginPage => loginPage ??= new LoginPage ();
    public void Go(MarkupPage page) => _navigationWindow.NavigationService.Navigate (page);
    public void Back(MarkupPage page) => _navigationWindow.NavigationService.GoBack ();
}
