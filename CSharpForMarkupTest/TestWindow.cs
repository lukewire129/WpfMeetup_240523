using CSharpForMakupTest.Core;
using static CSharpMarkup.Wpf.Helpers;
namespace CSharpForMarkupTest;

public class TestWindow : MarkupWindow
{
    public override void Build() => Content =
        VStack (
             TextBlock("hihi1"),
             TextBlock("hihi"),
             TextBlock("aaaaa")
            );
}