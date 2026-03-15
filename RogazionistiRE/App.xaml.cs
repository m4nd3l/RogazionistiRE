using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.AppNotifications;
using Microsoft.Windows.AppNotifications.Builder;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Language;
using RogazionistiRE.Util;
using RogazionistiRE.Windows;
using System;
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
        
        string? langIndex = FileWriter.aReadRFalse("langIndex");
        if (langIndex == "false" || langIndex == null) LanguageManager.selectLanguage(1);
        else {
            try {
                int index = Int32.Parse(langIndex); 
                LanguageManager.selectLanguage(index);
            } 
            catch { LanguageManager.selectLanguage(1); }
        }
    }
    
    protected override async void OnLaunched(LaunchActivatedEventArgs args) {
        LanguageManager.initialize();
        if (_isLoggedIn) {
            notify(LanguageManager.getTranslation(LanguageKeys.LoggingIn_Notification));
            LoginData loginData = LoginData.getCredentialFromLocker();
            if (loginData == null) {
                switchToLoginWindow();
                notify(LanguageManager.getTranslation(LanguageKeys.Error_Errors), LanguageManager.getTranslation(LanguageKeys.ErrorAutoCredsNotFound_LoginPage));
                return;
            }
            var (result, succeded) = await loginData.login();
            _login = result;
            if (result == null || !succeded) {
                switchToLoginWindow();
                notify(LanguageManager.getTranslation(LanguageKeys.Error_Errors), LanguageManager.getTranslation(LanguageKeys.ErrorAutoCreds_LoginPage));
                return;
            }
            _window = new Login();
            var page = new Students(result);
            await page.init();
            _window.Content =  page;
            _window.Closed  += onNoNFinalWindowClose;
            _window.Activate();
        } else switchToLoginWindow();
    }

    private static void onNoNFinalWindowClose(object sender, WindowEventArgs args) {
        FileWriter.aSave("langIndex", $"{LanguageManager.getSelectedIndex()}");
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
        _window        =  new Login();
        _window.Closed += onNoNFinalWindowClose;
        if (oldWindow != null)
            _window.AppWindow.Move(oldWindow.AppWindow.Position);
        _window.Activate();
        if (oldWindow != null && oldWindow != _window)
            oldWindow.Close();
    }
    
    
    #endregion
    private static void notify(string title, string msg) {
        AppNotification notification = new AppNotificationBuilder()
            .AddText(title)
            .AddText(msg)
            .BuildNotification();
        AppNotificationManager.Default.Show(notification);
    }
    
    private static void notify(string title) {
        AppNotification notification = new AppNotificationBuilder()
            .AddText(title)
            .BuildNotification();
        AppNotificationManager.Default.Show(notification);
    }
}

