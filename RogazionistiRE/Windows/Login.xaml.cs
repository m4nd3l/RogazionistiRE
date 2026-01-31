using Microsoft.UI.Xaml;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
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
        errors.Text = errorMessage;
    }

    private async void login(object sender, RoutedEventArgs e) {
        // GETS THE DATA AND CREATES A LOGIN DATA OBJECT
        string username = usernameBox.Text;
        string password = passwordBox.Password;
        LoginData loginData = new LoginData(username, password);
        // DEMO MODE
        if (loginData.getUserName().Equals("demo") && loginData.getPassword().Equals("demo")) {
            LoginResultJson? demoResult = loginData.demoLogin();
            rememberMeManagement(loginData);
            var demoPage = new Home(demoResult, true);
            await demoPage.init();
            Content = demoPage;
            return;
        }
        
        var (result, succeded) = await loginData.login();

        if (!succeded || result == null) {
            errors.Text = "Errore, username o password non validi.";
            return;
        }

        rememberMeManagement(loginData);
        
        Debug.WriteLine("The result of the login is the following...");
        Debug.WriteLine(result);
        
        var page = new Home(result);
        await page.init();
        Content = page;
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
