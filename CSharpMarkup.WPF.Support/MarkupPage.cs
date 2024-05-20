using System.Windows.Controls;

namespace CSharpMarkup.WPF.Support;

public abstract class MarkupPage : Page, IBuild
{
    public new object Content { get => base.Content; set { base.Content = value is CSharpMarkup.Wpf.DependencyObject d ? d.UI : value; } }

    public abstract void Build();
}
