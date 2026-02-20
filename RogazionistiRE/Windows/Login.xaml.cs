using Microsoft.UI.Xaml;
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
        errors.Text                 = errorMessage;
        LoginTitleBar.Title         = LanguageManager.getTitle(LanguageKeys.Login_LoginPage);
        usernameBox.PlaceholderText = LanguageManager.getTranslation(LanguageKeys.Username_LoginPage);
        passwordBox.PlaceholderText = LanguageManager.getTranslation(LanguageKeys.Password_LoginPage);
        rememberMe.Content          = LanguageManager.getTranslation(LanguageKeys.RememberMe_LoginPage);
        loginButton.Content = LanguageManager.getTranslation(LanguageKeys.Login_LoginPage);
    }

    private async void login(object sender, RoutedEventArgs e) {
        loginButton.IsEnabled = false;
        // GETS THE DATA AND CREATES A LOGIN DATA OBJECT
        string username = usernameBox.Text;
        string password = passwordBox.Password;
        LoginData loginData = new LoginData(username, password);
        
        // CHECKS IF ONE OR BOTH OF THE FIELDS ARE EMPTY
        if (username == "" || password == "") {
            errors.Text           = LanguageManager.getTranslation(LanguageKeys.ErrorFields_LoginPage);
            loginButton.IsEnabled = true;
            return;
        }
        
        // DEMO MODE
        if (loginData.getUserName().Equals("demo") && loginData.getPassword().Equals("demo")) {
            LoginResultJson? demoResult = loginData.demoLogin();
            rememberMeManagement(loginData);
            App._login = demoResult;
            var page = new Students(demoResult, true);
            await page.init();
            App.switchPage(page);
            return;
        }
        
        var (result, succeded) = await loginData.login();

        if (!succeded || result == null) {
            errors.Text           = LanguageManager.getTranslation(LanguageKeys.ErrorCreds_LoginPage);
            loginButton.IsEnabled = true;
            return;
        }

        rememberMeManagement(loginData);
        
        App._login = result;
        var realPage = new Students(result);
        await realPage.init();
        App.switchPage(realPage);
        loginButton.IsEnabled = true;
    }

    private void rememberMeManagement(LoginData loginData) {
        //REMEMBER ME MANAGEMENT
        if (rememberMe.IsChecked == true && 
            LoginData.getCredentialFromLocker() == loginData) {
            Debug.WriteLine("Saving credentials...");
            Debug.WriteLine($"Already saved credentials: {LoginData.getCredentialFromLocker()}");
            return;
        }
        if (rememberMe.IsChecked == true) {
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
}
