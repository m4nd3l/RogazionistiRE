using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using RogazionistiRE.Finestre;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Util;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE;

public partial class App : Application
{
    private static Window? _window;
    private static bool isLoggedIn;

    public App() {
        InitializeComponent();
        string? isLoggedValue = FileWriter.aReadRFalse("isLoggedIn");
        if (isLoggedValue == null) {
            isLoggedIn = false;
            return;
        }
        
        if (isLoggedValue.Contains("true")) 
            isLoggedIn = true;
        else {
            FileWriter.aSave("isLoggedIn", "false");
            isLoggedIn = false;
        }
        //isLoggedIn = false; // DEBUG MODE
        Debug.WriteLine("isLoggedIn: " + FileWriter.aReadRFalse("isLoggedIn"));
    }
    
    protected override void OnLaunched(LaunchActivatedEventArgs args) {
        if (isLoggedIn) {
            LoginData loginData = LoginData.getCredentialFromLocker();
            if (loginData == null) {
                switchToLoginWindow("Couldn't find any login data in the locker.");
                return;
            }
            string[] result = []; //await loginData.loginIntoMastercomSTARTUP();

            if (result == null) {
                switchToLoginWindow("Login automatico fallito, provare con il login manuale.");
                return;
            } else {
                _window = new Login();
                var page = new Home(result[0], result[1]);
                _window.Content = page;
                _window.Activate();
            }
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
        if (error != "") Debug.Write($"switchToLoginWindow() - {error}");
        _window = new Login(error);
        if (oldWindow != null)
            _window.AppWindow.Move(oldWindow.AppWindow.Position);
        _window.Activate();
        if (oldWindow != null && oldWindow != _window)
            oldWindow.Close();
    }
    #endregion
}

