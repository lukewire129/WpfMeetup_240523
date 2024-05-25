using SkiaSharp;
using System.Windows.Media;

namespace CSharpMarkup.WPF.Support.Controls;

public class SkiaText : SKPaint
{
    public SkiaText()
    {

    }

    public SkiaText TextColor(Brush brush)
    {
        return TextColor (((SolidColorBrush)brush).Color);
    }

    public SkiaText TextColor(Color color)
    {
        this.Color = new SKColor (color.R, color.G, color.B, color.A);
        return this;
    }

    public SkiaText TextColor(string hexString)
    {
        if(hexString.Contains("#") == false)
        {
            hexString = $"#{hexString}";
        }
        this.Color = SKColor.Parse (hexString);
        return this;
    }

    public SkiaText FontSize(double size)
    {
        this.TextSize = (float)size;

        return this;
    }
}
