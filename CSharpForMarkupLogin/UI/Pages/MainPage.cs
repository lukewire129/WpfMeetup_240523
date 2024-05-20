using System.Windows;

namespace CSharpForMarkupLogin.UI.Pages;

public partial class MainPage
{
    enum Columns { Side, Main }
    enum Rows { Main, Ad }
    public override void Build() => Content =
        Grid(
            Rows(
                (Rows.Main, 541),
                (Rows.Ad, 100)
                ),

                Grid (
                    Columns (
                        (Columns.Side, 66),
                        (Columns.Main, 325)
                        ),
                    Grid ()
                        .Grid_Column (Columns.Side)
                        .Background("#ececed"),

                    Grid ()
                        .Grid_Column (Columns.Main)
                ).Grid_Row(Rows.Main),

                Border(
                    TextBlock("광고문의 010.....")
                        .FontWeight("Bold")
                        .VCenter()
                        .HCenter()
                        .Background("#f8f8f8")

                )
                .BorderThicknesses(top:1)
                .BorderBrush("#dedede")
                .Grid_Row(Rows.Ad)
        );
}
