using CSharpMarkup.Wpf;
using Windows = System.Windows;
using Controls = System.Windows.Controls;
namespace CSharpMarkup.WPF.Support;

public static partial class Helpers
{
    public static UIElement Row(params Windows.UIElement[] children)
    {
        if (children == null)
            return null;

        var grid = CSharpMarkup.Wpf.Helpers.Grid (children);

        return grid;
    }
    public static Grid Grid(UIElement Row)
    {
        if (Row == null)
            return CSharpMarkup.Wpf.Helpers.Grid ();


        return Grid (Row);
    }
}
