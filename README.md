1. 깃허브 프로젝트 Clone
```
https://github.com/lukewire129/WpfMeetup_240523.git
```

2. WPF 프로젝트 생성 및 App.xaml, MainWindow.Xaml 제거
3. Clone 한 프로젝트의 프로젝트 추가하기
4. MainWindow 클래스 생성 (MarkupWindow 상속)
6. App 클래스 생성 및 아래 코드 삽입
```
public class App : MarkupApplication
{
    public App()
    {
        MainWindow = new MainWindow ();
    }
}
```
7. Starter 클래스 생성 및 아래 코드 삽입
```
public class Starter
{
    [STAThread]
    private static void Main(string[] args)
    {
        _ = new App ()
            .Run ();
    }
}
```
8. GlobalUsing 클래스 생성 및 아래 코드 삽입
```
﻿global using System;
global using System.Collections.Generic;
global using System.Threading;
global using System.Threading.Tasks;
global using static CSharpMarkup.Wpf.Helpers;
global using static System.Windows.Media.Colors;
global using Base = System.Windows;
global using ICommand = System.Windows.Input.ICommand;
global using BindingMode = System.Windows.Data.BindingMode;
global using Button_UI = System.Windows.Controls.Button;
global using TextBlock_UI = System.Windows.Controls.TextBlock;
global using TextBox_UI = System.Windows.Controls.TextBox;
global using InlineCollection_UI = System.Windows.Documents.InlineCollection;
global using ListViewItem_UI = System.Windows.Controls.ListViewItem;

global using CSharpMarkup.WPF.Support;
global using CSharpMarkup.Wpf;
```
