## CSharpforMarkup2이란?
- 마크업 언어(xaml) 대신 CSharp으로만 UI를 그리는 기술
  
## 실습
- 깃허브 프로젝트 Clone
```
https://github.com/lukewire129/WpfMeetup_240523.git
```

- WPF 프로젝트 생성 및 App.xaml, MainWindow.Xaml 제거
- Clone 한 프로젝트의 프로젝트 추가하기
- MainWindow 클래스 생성 (MarkupWindow 상속)
- App 클래스 생성 및 아래 코드 삽입
```
public class App : MarkupApplication
{
    public App()
    {
        MainWindow = new MainWindow ();
    }
}
```
- Starter 클래스 생성 및 아래 코드 삽입
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
- GlobalUsing 클래스 생성 및 아래 코드 삽입
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
![image](https://github.com/lukewire129/WpfMeetup_240523/assets/54387261/240051b2-f4a1-40d7-9a68-96581f154c22)
### Smile
```
M12,2C6.47,2 2,6.47 2,12C2,17.53 6.47,22 12,22A10,10 0 0,0 22,12C22,6.47 17.5,2 12,2M12,20A8,8 0 0,1 4,12A8,8 0 0,1 12,4A8,8 0 0,1 20,12A8,8 0 0,1 12,20M13,9.94L14.06,11L15.12,9.94L16.18,11L17.24,9.94L15.12,7.82L13,9.94M8.88,9.94L9.94,11L11,9.94L8.88,7.82L6.76,9.94L7.82,11L8.88,9.94M12,17.5C14.33,17.5 16.31,16.04 17.11,14H6.89C7.69,16.04 9.67,17.5 12,17.5Z
```
### Bell
```
M10 21H14C14 22.1 13.1 23 12 23S10 22.1 10 21M21 19V20H3V19L5 17V11C5 7.9 7 5.2 10 4.3V4C10 2.9 10.9 2 12 2S14 2.9 14 4V4.3C17 5.2 19 7.9 19 11V17L21 19M17 11C17 8.2 14.8 6 12 6S7 8.2 7 11V18H17V11Z
```

### Cog
```
M12,8A4,4 0 0,1 16,12A4,4 0 0,1 12,16A4,4 0 0,1 8,12A4,4 0 0,1 12,8M12,10A2,2 0 0,0 10,12A2,2 0 0,0 12,14A2,2 0 0,0 14,12A2,2 0 0,0 12,10M10,22C9.75,22 9.54,21.82 9.5,21.58L9.13,18.93C8.5,18.68 7.96,18.34 7.44,17.94L4.95,18.95C4.73,19.03 4.46,18.95 4.34,18.73L2.34,15.27C2.21,15.05 2.27,14.78 2.46,14.63L4.57,12.97L4.5,12L4.57,11L2.46,9.37C2.27,9.22 2.21,8.95 2.34,8.73L4.34,5.27C4.46,5.05 4.73,4.96 4.95,5.05L7.44,6.05C7.96,5.66 8.5,5.32 9.13,5.07L9.5,2.42C9.54,2.18 9.75,2 10,2H14C14.25,2 14.46,2.18 14.5,2.42L14.87,5.07C15.5,5.32 16.04,5.66 16.56,6.05L19.05,5.05C19.27,4.96 19.54,5.05 19.66,5.27L21.66,8.73C21.79,8.95 21.73,9.22 21.54,9.37L19.43,11L19.5,12L19.43,13L21.54,14.63C21.73,14.78 21.79,15.05 21.66,15.27L19.66,18.73C19.54,18.95 19.27,19.04 19.05,18.95L16.56,17.95C16.04,18.34 15.5,18.68 14.87,18.93L14.5,21.58C14.46,21.82 14.25,22 14,22H10M11.25,4L10.88,6.61C9.68,6.86 8.62,7.5 7.85,8.39L5.44,7.35L4.69,8.65L6.8,10.2C6.4,11.37 6.4,12.64 6.8,13.8L4.68,15.36L5.43,16.66L7.86,15.62C8.63,16.5 9.68,17.14 10.87,17.38L11.24,20H12.76L13.13,17.39C14.32,17.14 15.37,16.5 16.14,15.62L18.57,16.66L19.32,15.36L17.2,13.81C17.6,12.64 17.6,11.37 17.2,10.2L19.31,8.65L18.56,7.35L16.15,8.39C15.38,7.5 14.32,6.86 13.12,6.62L12.75,4H11.25Z
```
