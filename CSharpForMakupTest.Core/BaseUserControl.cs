using System.Windows.Controls;

namespace CSharpForMakupTest.Core;

public class BaseUserControl : UserControl, IBuild
{
    public new object Content { get => base.Content; set { base.Content = value is CSharpMarkup.Wpf.DependencyObject d ? d.UI : value; } }

    public virtual void Build()
    {
    }
}
