using System.Windows;

namespace CSharpMarkup.WPF.Support;

public abstract class MarkupWindow  : Window, IBuild
{
    public abstract void Build();
}
