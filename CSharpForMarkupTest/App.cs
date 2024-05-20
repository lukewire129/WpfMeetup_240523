﻿using CSharpForMakupTest.Core;
using System.Windows;
namespace CSharpForMarkupTest;

public class App : MarkupApplication
{
    public App()
    {
        MainWindow = new AppWindow ();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow.Show ();
        base.OnStartup(e);
    }
}