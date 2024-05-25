using System.Windows.Controls;

namespace CSharpMarkup.WPF.Support;

public abstract class MarkupPage : Page, IBuild
{
    public abstract void Build();
}