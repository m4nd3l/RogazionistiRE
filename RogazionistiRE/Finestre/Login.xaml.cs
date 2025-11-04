using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE.Finestre;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class Login : Window
{
    public Login()
    {
        InitializeComponent();
        ExtendsContentIntoTitleBar = true;
        SetTitleBar(LoginTitleBar);
    }

    private void creaCartella(object sender, RoutedEventArgs e) {
        hello.Width = 2;

        FileWriter.initializeApplicationDataFolder();

        var fileName1 = Path.Combine(FileWriter.appDataPath, "lmao2.poops");
        FileWriter.createFile(fileName1, "hello :3 <3");

        Debug.WriteLine(File.Exists(fileName1) ? "esisto lmao2.poops!" : "=(");
        Debug.WriteLine(File.Exists(fileName1) ? fileName1 : "=( wewewe");

    }
}
