using System.Windows;

namespace CSharpMarkup.WPF.Support;

public abstract class MarkupApplication : Application
{
    public MarkupApplication()
    {
#if DEBUG
        HotReloadManager.Init (this);
#endif
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow.Show ();
        base.OnStartup (e);
    }
}