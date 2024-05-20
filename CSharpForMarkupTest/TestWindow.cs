using CSharpMarkup.WPF.Support;
using static CSharpMarkup.Wpf.Helpers;
namespace CSharpForMarkupTest;

public class TestWindow : MarkupWindow
{
    public TestWindow()
    {
        Build ();
    }
    public override void Build() => Content =
        VStack (
             TextBlock("hihi1"),
             TextBlock("hihi"),
             TextBlock("aaaaa")
            );
}