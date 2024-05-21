using System.Windows.Input;

namespace CSharpForMarkupLogin.Views;
public partial class LoginPage : MarkupPage
{
    enum OptionColumn { Cog, Minimize, Close }
    readonly string KakaoCI = "M76.01 89.49 L87.99 89.49 L87.99 89.49 L82 72.47 L76.01 89.49 Z M104,0C46.56,0,0,36.71,0,82c0,29.28,19.47,55,48.75,69.48-1.59,5.49-10.24,35.34-10.58,37.69,0,0-.21,1.76.93,2.43a3.14,3.14,0,0,0,2.48.15c3.28-.46,38-24.81,44-29A131.56,131.56,0,0,0,104,164c57.44,0,104-36.71,104-82S161.44,0,104,0ZM52.53,69.27c-.13,11.6.1,23.8-.09,35.22-.06,3.65-2.16,4.74-5,5.78a1.88,1.88,0,0,1-1,.07c-3.25-.64-5.84-1.8-5.92-5.84-.23-11.41.07-23.63-.09-35.23-2.75-.11-6.67.11-9.22,0-3.54-.23-6-2.48-5.85-5.83s1.94-5.76,5.91-5.82c9.38-.14,21-.14,30.38,0,4,.06,5.78,2.48,5.9,5.82s-2.3,5.6-5.83,5.83C59.2,69.38,55.29,69.16,52.53,69.27Zm50.4,40.45a9.24,9.24,0,0,1-3.82.83c-2.5,0-4.41-1-5-2.65l-3-7.78H72.85l-3,7.78c-.58,1.63-2.49,2.65-5,2.65a9.16,9.16,0,0,1-3.81-.83c-1.66-.76-3.25-2.86-1.43-8.52L74,63.42a9,9,0,0,1,8-5.92,9.07,9.07,0,0,1,8,5.93l14.34,37.76C106.17,106.86,104.58,109,102.93,109.72Zm30.32,0H114a5.64,5.64,0,0,1-5.75-5.5V63.5a6.13,6.13,0,0,1,12.25,0V98.75h12.75a5.51,5.51,0,1,1,0,11Zm47-4.52A6,6,0,0,1,169.49,108L155.42,89.37l-2.08,2.08v13.09a6,6,0,0,1-12,0v-41a6,6,0,0,1,12,0V76.4l16.74-16.74a4.64,4.64,0,0,1,3.33-1.34,6.08,6.08,0,0,1,5.9,5.58A4.7,4.7,0,0,1,178,67.55L164.3,81.22l14.77,19.57A6,6,0,0,1,180.22,105.23Z";
    public override void Build() => Content =
        VStack (
            Grid (
                Columns (
                    (OptionColumn.Cog, Auto),
                    (OptionColumn.Minimize, Auto),
                    (OptionColumn.Close, Auto)
                ),

                TaskBarButton (Cog)
                        .Grid_Column (OptionColumn.Cog),

                TaskBarButton (Minimize)
                        .Grid_Column (OptionColumn.Minimize).Margins (bottom: 7),

                TaskBarButton (Close)
                        .Grid_Column (OptionColumn.Close).Margins (bottom: 2)

            ).Margins (left: 10, top: 6, right: 10, bottom: 30).Right (),

            Viewbox (
                    Path ()
                        .Data (KakaoCI).Fill ("#423630")
                ).Width (100).Height (100),

            Border (
                VStack (
                        Grid (
                            TextBox ("aaa")
                                .Height (37)
                                .Padding(5)
                                .VerticalContentAlignment(System.Windows.VerticalAlignment.Center)
                                .Top (),
                            TextBox ()
                                .Height (37)
                                .Padding (5)
                                .VerticalContentAlignment (System.Windows.VerticalAlignment.Center)
                                .Bottom ()
                        ).Height (74),

                        Button ()
                            .Height (37)
                            .Margins (top: 5, bottom: 20)
                            .Bind (vm.LoginCommand),

                        Grid (
                            Border ()
                                .Width (250).Height (1).BorderThicknesses (top: 1).BorderBrush ("#f1d900"),

                            Label ("또는")
                                .Background ("#fee500")
                                .HCenter ()
                                .Foreground ("#7f7200")
                                .FontSize (11)
                        )
                    )
                ).Paddings (left: 59, top: 30, right: 59)

            )
            .Width (360).Height (590)
            .Background("#fee500");

    readonly string Cog = "M12,15.5A3.5,3.5 0 0,1 8.5,12A3.5,3.5 0 0,1 12,8.5A3.5,3.5 0 0,1 15.5,12A3.5,3.5 0 0,1 12,15.5M19.43,12.97C19.47,12.65 19.5,12.33 19.5,12C19.5,11.67 19.47,11.34 19.43,11L21.54,9.37C21.73,9.22 21.78,8.95 21.66,8.73L19.66,5.27C19.54,5.05 19.27,4.96 19.05,5.05L16.56,6.05C16.04,5.66 15.5,5.32 14.87,5.07L14.5,2.42C14.46,2.18 14.25,2 14,2H10C9.75,2 9.54,2.18 9.5,2.42L9.13,5.07C8.5,5.32 7.96,5.66 7.44,6.05L4.95,5.05C4.73,4.96 4.46,5.05 4.34,5.27L2.34,8.73C2.21,8.95 2.27,9.22 2.46,9.37L4.57,11C4.53,11.34 4.5,11.67 4.5,12C4.5,12.33 4.53,12.65 4.57,12.97L2.46,14.63C2.27,14.78 2.21,15.05 2.34,15.27L4.34,18.73C4.46,18.95 4.73,19.03 4.95,18.95L7.44,17.94C7.96,18.34 8.5,18.68 9.13,18.93L9.5,21.58C9.54,21.82 9.75,22 10,22H14C14.25,22 14.46,21.82 14.5,21.58L14.87,18.93C15.5,18.67 16.04,18.34 16.56,17.94L19.05,18.95C19.27,19.03 19.54,18.95 19.66,18.73L21.66,15.27C21.78,15.05 21.73,14.78 21.54,14.63L19.43,12.97Z";
    readonly string Minimize = "M20,14H4V10H20";
    readonly string Close = "M20 6.91L17.09 4L12 9.09L6.91 4L4 6.91L9.09 12L4 17.09L6.91 20L12 14.91L17.09 20L20 17.09L14.91 12L20 6.91Z";
    public Border TaskBarButton(string path) =>
        Border(
            Viewbox(
                    Path()
                        .Data(path)
                        .Fill("#33423630")
                ).Width(14)
                 .Height(14)
        )
        .Padding(4)
        .Cursor(Cursors.Hand)
        .Background(Transparent);
}
