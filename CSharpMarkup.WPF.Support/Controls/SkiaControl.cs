using SkiaSharp.Views.WPF;
using System.Windows;
using System.Windows.Media;

namespace CSharpMarkup.WPF.Support.Controls;

public class SkiaControl : SKElement
{
    public FontWeight FontWeight
    {
        get { return (FontWeight)GetValue (FontWeightProperty); }
        set { SetValue (FontWeightProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FontWeightProperty =
        DependencyProperty.Register ("FontWeight", typeof (FontWeight), typeof (SkiaControl), new PropertyMetadata (null));

    public FontStyle FontStyle
    {
        get { return (FontStyle)GetValue (FontStyleProperty); }
        set { SetValue (FontStyleProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FontStyleProperty =
        DependencyProperty.Register ("FontStyle", typeof (FontStyle), typeof (SkiaControl), new PropertyMetadata (null));

    public FontStretch FontStretch
    {
        get { return (FontStretch)GetValue (FontStretchProperty); }
        set { SetValue (FontStretchProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FontStretchProperty =
        DependencyProperty.Register ("FontStretch", typeof (FontStyle), typeof (SkiaControl), new PropertyMetadata (null));


    public double FontSize
    {
        get { return (double)GetValue (FontSizeProperty); }
        set { SetValue (FontSizeProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FontSizeProperty =
        DependencyProperty.Register ("FontSize", typeof (double), typeof (SkiaControl), new PropertyMetadata (null));


    public FontFamily FontFamily
    {
        get { return (FontFamily)GetValue (FontFamilyeProperty); }
        set { SetValue (FontFamilyeProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FontFamilyeProperty =
        DependencyProperty.Register ("FontFamily", typeof (FontFamily), typeof (SkiaControl), new PropertyMetadata (null));

    public Thickness BorderThickness
    {
        get { return (Thickness)GetValue (BorderThicknessProperty); }
        set { SetValue (BorderThicknessProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty BorderThicknessProperty =
        DependencyProperty.Register ("BorderThickness", typeof (Thickness), typeof (SkiaControl), new PropertyMetadata (null));


    public string Text
    {
        get { return (string)GetValue (TextProperty); }
        set { SetValue (TextProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register ("Text", typeof (string), typeof (SkiaControl), new PropertyMetadata (null));

}
