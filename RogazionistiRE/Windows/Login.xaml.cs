using CommunityToolkit.WinUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Language;
using RogazionistiRE.Windows.ContentDialogs;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE.Windows;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class Login : Window {
    public Login() {
        InitializeComponent();
        ExtendsContentIntoTitleBar = true;
        SetTitleBar(LoginTitleBar);
        Title.Text               = LanguageManager.getTranslation(LanguageKeys.Welcome_LoginPage);
        Signin.Text              = LanguageManager.getTranslation(LanguageKeys.Signin_LoginPage);
        LoginTitleBar.Title      = LanguageManager.getTitle(LanguageKeys.Login_LoginPage);
        Username.PlaceholderText = LanguageManager.getTranslation(LanguageKeys.Username_LoginPage);
        Password.PlaceholderText = LanguageManager.getTranslation(LanguageKeys.Password_LoginPage);
        RememberMe.Content       = LanguageManager.getTranslation(LanguageKeys.RememberMe_LoginPage);
        LoginButton.Content      = LanguageManager.getTranslation(LanguageKeys.Login_LoginPage);
        Auth.Text                = LanguageManager.getTranslation(LanguageKeys.Authenticating_LoginPage);
    }
    private void showOrHidePassword(object sender, RoutedEventArgs e) {
        if (Password.PasswordRevealMode == PasswordRevealMode.Hidden) {
            Password.PasswordRevealMode = PasswordRevealMode.Visible;
            ShowPasswordGlyph.Glyph     = "";
        } else {
            Password.PasswordRevealMode = PasswordRevealMode.Hidden;
            ShowPasswordGlyph.Glyph     = "";
        }
    }
    private async Task error(string errorMessage) {
        ContentDialog dialog = new ContentDialog {
            XamlRoot = Content.XamlRoot,
            Title = LanguageManager.getTranslation(LanguageKeys.Error_LoginPage),
            Content = errorMessage,
            CloseButtonText = LanguageManager.getTranslation(LanguageKeys.Close_MoreInfoPage),
            CornerRadius = new CornerRadius(12),
        };
        await dialog.ShowAsync();
    }
    private async void login(object sender, RoutedEventArgs e) {
        LoginButton.IsEnabled = false;
        // GETS THE DATA AND CREATES A LOGIN DATA OBJECT
        string username = Username.Text;
        string password = Password.Password;
        LoginData loginData = new LoginData(username, password);
        
        // CHECKS IF ONE OR BOTH OF THE FIELDS ARE EMPTY
        if (username == "" || password == "") {
            await error(LanguageManager.getTranslation(LanguageKeys.ErrorFields_LoginPage));
            LoginButton.IsEnabled = true;
            return;
        }
        
        startOverlay();
        
        // DEMO MODE
        if (loginData.getUserName().Equals("demo") && loginData.getPassword().Equals("demo")) {
            LoginResultJson? demoResult = loginData.demoLogin();
            await rememberMeManagement(loginData);
            App._login = demoResult;
            var page = new Students(demoResult, true);
            await page.init();
            App.switchPage(page);
            stopOverlay();
            return;
        }
        var (result, succeded) = await loginData.login();

        if (!succeded || result == null) {
            await error(LanguageManager.getTranslation(LanguageKeys.ErrorCreds_LoginPage));
            stopOverlay();
            LoginButton.IsEnabled = true;
            return;
        }

        await rememberMeManagement(loginData);
        
        App._login = result;
        var realPage = new Students(result);
        await realPage.init();
        stopOverlay();
        App.switchPage(realPage);
        LoginButton.IsEnabled = true;
    }
    private async Task rememberMeManagement(LoginData loginData) {
        if (RememberMe.IsChecked == true) loginData.saveData();
        else LoginData.deleteData();
    }
    private void startOverlay() {
        FadeInOverlay.Begin();
    }
    private void stopOverlay() {
        FadeOutOverlay.Begin();
    }
    private async void changeLanguage(object sender, RoutedEventArgs e) {
        ChangeLanguageContentDialog dialog = new ChangeLanguageContentDialog() { XamlRoot = Content.XamlRoot };
        await dialog.ShowAsync();
        Title.Text               = LanguageManager.getTranslation(LanguageKeys.RogazionistiRE_Winbar);
        LoginTitleBar.Title      = LanguageManager.getTitle(LanguageKeys.Login_LoginPage);
        Username.PlaceholderText = LanguageManager.getTranslation(LanguageKeys.Username_LoginPage);
        Password.PlaceholderText = LanguageManager.getTranslation(LanguageKeys.Password_LoginPage);
        RememberMe.Content       = LanguageManager.getTranslation(LanguageKeys.RememberMe_LoginPage);
        LoginButton.Content      = LanguageManager.getTranslation(LanguageKeys.Login_LoginPage);
    }
}
