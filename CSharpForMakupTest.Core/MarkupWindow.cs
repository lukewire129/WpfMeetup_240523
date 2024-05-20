using System.Windows;

namespace CSharpForMakupTest.Core;

public abstract class MarkupWindow  : Window, IBuild
{
    public new object Content { get => base.Content; set { base.Content = value is CSharpMarkup.Wpf.DependencyObject d ? d.UI : value; } }

    public abstract void Build();
}
