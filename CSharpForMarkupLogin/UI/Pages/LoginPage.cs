using CSharpMarkup.Wpf;
using CSharpMarkup.WPF.Support;
using static CSharpMarkup.Wpf.Helpers;
namespace CSharpForMarkupLogin.Views;

public class LoginPage : MarkupPage
{
    public LoginPage()
    {
        this.Build ();
    }

    public override void Build() => Content =
        VStack ()
        .Background("#fee500");
}
