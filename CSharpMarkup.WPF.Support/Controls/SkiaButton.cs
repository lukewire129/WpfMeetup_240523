using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System.Windows;

namespace CSharpMarkup.WPF.Support.Controls;

public class SkiaButton : SkiaButtonBase
{


    public Thickness CornerRadius
    {
        get { return (Thickness)GetValue (CornerRadiusProperty); }
        set { SetValue (CornerRadiusProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register ("CornerRadius", typeof (Thickness), typeof (SkiaButton), new PropertyMetadata (0));


    protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
    {
        base.OnPaintSurface (e);

        var canvas = e.Surface.Canvas;
        canvas.Clear (SKColors.Transparent);

        using (var paint = new SKPaint ())
        {
            paint.Color = SKColors.Blue;
            paint.IsAntialias = true;
            paint.Style = SKPaintStyle.Fill;

            var rect = new SKRect (0, 0, e.Info.Width, e.Info.Height);
            canvas.DrawRoundRect (rect, 10, 10, paint);
        }

        using (var textpaint = new SkiaText())
        {
            textpaint.Color = SKColors.White;
            textpaint.TextAlign = SKTextAlign.Center;
            textpaint.TextSize  = (float)this.FontSize;            
            canvas.DrawText (this.Text, e.Info.Width / 2, e.Info.Height / 2, textpaint);
        }
    }
}