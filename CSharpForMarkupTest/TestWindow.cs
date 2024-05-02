using CSharpForMakupTest.Core;
using static CSharpMarkup.Wpf.Helpers;
namespace CSharpForMarkupTest;

public class TestWindow : BaseWindow
{
    public override void Build() => Content =
        VStack (
             TextBlock("hihi"),
             TextBlock("hihi")
            );
}
