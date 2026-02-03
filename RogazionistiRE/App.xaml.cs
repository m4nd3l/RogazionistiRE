using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Util;
using RogazionistiRE.Windows;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE;

public partial class App : Application
{
    private static Window?           _window;
    public  static LoginResultJson?  _login;
    private static bool              _isLoggedIn;

    public App() {
        InitializeComponent();
        string? isLoggedValue = FileWriter.aReadRFalse("isLoggedIn");
        if (isLoggedValue == null) {
            _isLoggedIn = false;
            return;
        }
        
        if (isLoggedValue.Contains("true")) 
            _isLoggedIn = true;
        else {
            FileWriter.aSave("isLoggedIn", "false");
            _isLoggedIn = false;
        }
        Debug.WriteLine("isLoggedIn: " + FileWriter.aReadRFalse("isLoggedIn"));
    }
    
    protected override async void OnLaunched(LaunchActivatedEventArgs args) {
        if (_isLoggedIn) {
            LoginData loginData = LoginData.getCredentialFromLocker();
            if (loginData == null) {
                switchToLoginWindow("Couldn't find any login data in the locker.");
                return;
            }
            var (result, succeded) = await loginData.login();
            _login = result;
            if (result == null || !succeded) {
                switchToLoginWindow("Login automatico fallito, provare con il login manuale.");
                return;
            }
            _window = new Login();
            var page = new Students(result);
            await page.init();
            _window.Content = page;
            _window.Activate();
        } else switchToLoginWindow();
    }

    #region Window Management
    public static void setWindow(Window window) {
        var oldWindow = _window;
        _window = window;
        if(oldWindow != null)
            _window.AppWindow.Move(oldWindow.AppWindow.Position);
        _window.Activate();
        if (oldWindow != null && oldWindow != _window)
            oldWindow.Close();
    }
    public static void switchPage(Page page) {
        if (_window != null) {
            _window.Content = page;
            _window.Activate();
        }
    }
    
    public static void switchToLoginWindow(string error = "") {
        var oldWindow = _window;
        if (error != "") Debug.WriteLine($"switchToLoginWindow() - {error}");
        _window = new Login(error);
        if (oldWindow != null)
            _window.AppWindow.Move(oldWindow.AppWindow.Position);
        _window.Activate();
        if (oldWindow != null && oldWindow != _window)
            oldWindow.Close();
    }
    
    
    #endregion
}

