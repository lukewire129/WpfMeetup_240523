using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CSharpForMarkupTest.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] string sampleTest;

    [RelayCommand]
    private void Ok()
    {
        this.SampleTest = "hihi1";

        new TestWindow ().Show ();
    }
}