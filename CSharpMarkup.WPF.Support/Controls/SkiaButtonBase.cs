using System.Windows;
using System.Windows.Input;

namespace CSharpMarkup.WPF.Support.Controls;

public class SkiaButtonBase : SkiaControl
{
    public ICommand Command
    {
        get { return (ICommand)GetValue (CommandProperty); }
        set { SetValue (CommandProperty, value); }
    }

    public object CommandParameter
    {
        get { return (object)GetValue (CommandParameterProperty); }
        set { SetValue (CommandParameterProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register ("Command", typeof (ICommand), typeof (SkiaButtonBase), new PropertyMetadata (null));

    public static readonly DependencyProperty CommandParameterProperty =
       DependencyProperty.Register ("CommandParameter", typeof (object), typeof (SkiaButtonBase), new PropertyMetadata (null));

    public SkiaButtonBase()
    {
        this.MouseLeftButtonUp += SkiaButtonBase_MouseLeftButtonUp;
    }

    private void SkiaButtonBase_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        this.Command?.Execute (CommandParameter);
    }
}
