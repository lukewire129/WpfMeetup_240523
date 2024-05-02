#if DEBUG
using System.Windows;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler (typeof (CSharpForMakupTest.Core.HotReloadManager))]

namespace CSharpForMakupTest.Core;

public static class HotReloadManager
{
    public static LukeApplication app;
    public static void Init(LukeApplication application)
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
                    if (type.ToString () != window.ToString ())
                    {
                        continue;
                    }
                    ((IBuild)window).Build();
                }
            }
        });
}
#endif