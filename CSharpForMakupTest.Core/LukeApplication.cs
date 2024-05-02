using System.Windows;

namespace CSharpForMakupTest.Core;

public abstract class LukeApplication : Application
{
    public LukeApplication()
    {
        HotReloadManager.Init (this);
    }
}