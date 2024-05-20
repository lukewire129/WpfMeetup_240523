using System.Windows;

namespace CSharpForMakupTest.Core;

public abstract class MarkupApplication : Application
{
    public MarkupApplication()
    {
        HotReloadManager.Init (this);
    }
}