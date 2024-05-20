#if DEBUG
using System.Windows;
using System.Windows.Navigation;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler (typeof (CSharpMarkup.WPF.Support.HotReloadManager))]

namespace CSharpMarkup.WPF.Support;

public static class HotReloadManager
{
    public static MarkupApplication app;
    public static void Init(MarkupApplication application)
    {
        app = application;
    }
    public static void ClearCache(Type[]? types) { }

    public static void UpdateApplication(Type[]? types) =>
        app?.Dispatcher.Invoke (() =>
        {
            if (types is null)
                return;
            foreach (var window in Application.Current.Windows)
            {
                foreach (var type in types)
                {
                    if (window.ToString() == "Microsoft.VisualStudio.DesignTools.WpfTap.WpfVisualTreeService.Adorners.AdornerWindow")
                    {
                        continue;
                    }
                    if ((type.BaseType == typeof(MarkupPage) || type.BaseType == typeof(MarkupWindow)) == false)
                    {
                        continue;
                    }

                    object o = type.BaseType == typeof(MarkupWindow) ? window : ((NavigationWindow)window).NavigationService.Content;

                    ((IBuild)o).Build();
                }
            }
        });
}
#endif