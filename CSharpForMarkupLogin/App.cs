using CSharpForMarkupLogin.UI.Pages;
using CSharpForMarkupLogin.Views;

namespace CSharpForMarkupLogin;

public class App : MarkupApplication
{
    Base.Navigation.NavigationWindow _navigationWindow;
    private LoginPage? loginPage;
    private MainPage? mainPage;
    internal static new App? Current { get; private set; }
    public App()
    {
        Current = this;
        MainWindow = _navigationWindow = new Base.Navigation.NavigationWindow ()
        {
            SizeToContent= System.Windows.SizeToContent.WidthAndHeight,
            ShowsNavigationUI = false,
            WindowStyle = System.Windows.WindowStyle.None,
            AllowsTransparency = true,
        };

        _navigationWindow.MouseDown += (s, e) =>
        {
            _navigationWindow.DragMove ();
        };

        Go (LoginPage);
    }


    LoginPage LoginPage => loginPage ??= new LoginPage ();
    MainPage MainPage => mainPage ??= new MainPage ();
    public void Go(MarkupPage page) => _navigationWindow.NavigationService.Navigate (page);

    public void Back(MarkupPage page) => _navigationWindow.NavigationService.GoBack ();
    public void GoMainPage() => _navigationWindow.NavigationService.Navigate (MainPage);
}
