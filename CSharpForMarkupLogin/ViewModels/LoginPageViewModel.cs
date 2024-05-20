using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CSharpForMarkupLogin.ViewModels;

public partial class LoginPageViewModel: ObservableObject
{
    [RelayCommand]
    private void Login()
    {
        App.Current.GoMainPage ();
    }
}
