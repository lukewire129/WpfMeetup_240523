using CSharpForMarkupLogin.ViewModels;

namespace CSharpForMarkupLogin.Views;
public partial class LoginPage : MarkupPage
{
    private LoginPageViewModel vm;
    public LoginPage()
    {
        this.DataContext = vm = new LoginPageViewModel ();
        this.Build ();
    }
}
