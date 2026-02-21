using CommunityToolkit.WinUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Language;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE.Windows;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class Login : Window {
    public Login(string errorMessage = "") {
        InitializeComponent();
        ExtendsContentIntoTitleBar = true;
        SetTitleBar(LoginTitleBar);
        Title.Text                  = LanguageManager.getTranslation(LanguageKeys.RogazionistiRE_Winbar);
        Errors.Text                 = errorMessage;
        LoginTitleBar.Title         = LanguageManager.getTitle(LanguageKeys.Login_LoginPage);
        Username.PlaceholderText    = LanguageManager.getTranslation(LanguageKeys.Username_LoginPage);
        Password.PlaceholderText    = LanguageManager.getTranslation(LanguageKeys.Password_LoginPage);
        RememberMe.Content          = LanguageManager.getTranslation(LanguageKeys.RememberMe_LoginPage);
        LoginButton.Content         = LanguageManager.getTranslation(LanguageKeys.Login_LoginPage);
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
    
    private async void login(object sender, RoutedEventArgs e) {
        LoginButton.IsEnabled = false;
        // GETS THE DATA AND CREATES A LOGIN DATA OBJECT
        string username = Username.Text;
        string password = Password.Password;
        LoginData loginData = new LoginData(username, password);
        
        // CHECKS IF ONE OR BOTH OF THE FIELDS ARE EMPTY
        if (username == "" || password == "") {
            Errors.Text           = LanguageManager.getTranslation(LanguageKeys.ErrorFields_LoginPage);
            LoginButton.IsEnabled = true;
            return;
        }
        
        startOverlay();
        
        // DEMO MODE
        if (loginData.getUserName().Equals("demo") && loginData.getPassword().Equals("demo")) {
            LoginResultJson? demoResult = loginData.demoLogin();
            rememberMeManagement(loginData);
            App._login = demoResult;
            var page = new Students(demoResult, true);
            await page.init();
            App.switchPage(page);
            stopOverlay();
            return;
        }
        var (result, succeded) = await loginData.login();

        if (!succeded || result == null) {
            Errors.Text           = LanguageManager.getTranslation(LanguageKeys.ErrorCreds_LoginPage);
            stopOverlay();
            LoginButton.IsEnabled = true;
            return;
        }

        rememberMeManagement(loginData);
        
        App._login = result;
        var realPage = new Students(result);
        await realPage.init();
        App.switchPage(realPage);
        LoginButton.IsEnabled = true;
        stopOverlay();
    }
    private void rememberMeManagement(LoginData loginData) {
        if (RememberMe.IsChecked == true && 
            LoginData.getCredentialFromLocker() == loginData) {
            Debug.WriteLine("Saving credentials...");
            Debug.WriteLine($"Already saved credentials: {LoginData.getCredentialFromLocker()}");
            return;
        }
        if (RememberMe.IsChecked == true) {
            Debug.WriteLine("Saving credentials...");
            loginData.saveData();
            Debug.WriteLine("Credentials saved!");
            Debug.WriteLine($"Here are them: {LoginData.getCredentialFromLocker()}");
            Debug.WriteLine($"They should like this: {loginData}");
        } else {
            Debug.WriteLine("Logged in without saving...");
            LoginData.deleteData();
        }
    }
    private void startOverlay() {
        Progress.Visibility = Visibility.Visible;
    }
    private void stopOverlay() {
        Progress.Visibility = Visibility.Collapsed;
    }
}
