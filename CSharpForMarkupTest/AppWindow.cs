using CSharpMarkup.WPF.Support;
using CSharpForMarkupTest.ViewModels;
using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;

namespace CSharpForMarkupTest;

public class AppWindow : MarkupWindow
{
    MainViewModel vm;
    public AppWindow()
    {
        this.DataContext = vm = new MainViewModel ();
        Build ();
    }

    public override void Build() => Content =
        VStack (
            TextBlock ()
               .Bind (vm.SampleTest),
            Button ("Test!")
               .Width(100)
               .Height(100)
               .HorizontalAlignment(System.Windows.HorizontalAlignment.Center)
               .Bind(vm.OkCommand)
            );
}
