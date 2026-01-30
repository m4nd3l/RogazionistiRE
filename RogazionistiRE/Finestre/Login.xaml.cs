using Microsoft.UI.Xaml;
using System.Diagnostics;

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

    public Login(string errorMessage) {
        InitializeComponent();
        ExtendsContentIntoTitleBar = true;
        SetTitleBar(LoginTitleBar);
        errors.Text = errorMessage;
    }

    private async void login(object sender, RoutedEventArgs e) {
        // CREATES THE LOGIN DATA 
        string username = userNameBox.Text;
        string psw = pswBox.Password;
        LoginData loginData = new LoginData(username, psw);

        // LOGIN INTO MASTERCOM & ERRORS MANAGEMENT
        string[] result = await loginData.loginIntoMastercom();

        if (result.Length == 1) {
            errors.Text = "Errore, username o password non validi.";
            return;
        }

        //REMEMBER ME MANAGEMENT
        if (rememberMe.IsChecked == true
            && LoginData.GetCredentialFromLocker() == loginData) {
            Debug.WriteLine("Saving credentials...");
            Debug.WriteLine($"Already saved credentials: {LoginData.GetCredentialFromLocker()}");
            return;
        } else if (rememberMe.IsChecked == true) {
            Debug.WriteLine("Saving credentials...");
            loginData.saveData();
            Debug.WriteLine("Credentials saved!");
            Debug.WriteLine($"Here are them: { LoginData.GetCredentialFromLocker()}");
            Debug.WriteLine($"They should like this: {loginData}");
        } else {
            Debug.WriteLine("Logged in without saving...");
            LoginData.deleteData();
        }
        Debug.WriteLine("The result of the login is the following...");
        Debug.WriteLine(result[0] + " \n---\n" + result[1]); // DEBUG

        var page = new Home(result[0], result[1]);
        this.Content = page;
    }
}
