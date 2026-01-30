using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using RogazionistiRE.Finestre;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Util;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        private static Window? _window;
        public static bool isLoggedIn;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App() {
            InitializeComponent();

            if (FileWriter.aReadRFalse("isLoggedIn").Contains("true")) 
                isLoggedIn = true;
            else {
                FileWriter.aSave("isLoggedIn", "false");
                isLoggedIn = false;
            }
            //isLoggedIn = false; // DEBUG MODE
            Debug.WriteLine("isLoggedIn: " + FileWriter.aReadRFalse("isLoggedIn"));
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs args) {
            if (isLoggedIn) {
                LoginData loginData = LoginData.getCredentialFromLocker();
                string[] result = [];//await loginData.loginIntoMastercomSTARTUP();

                if (result == null) { 
                    Debug.WriteLine("Login failed - loginData.loginIntoMastercomSTARTUP() returned: |\"false\"|");
                    _window = new Login("Login automatico fallito, provare con il login manuale.");
                } else {
                    _window = new Login();
                    var page = new Home(result[0], result[1]);
                    _window.Content = page;
                }
            } else 
                _window = new Login();
            _window.Activate();
        }

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

        public static void switchToLoginWindow() {
            var oldWindow = _window;
            _window = new Login();
            if (oldWindow != null)
                _window.AppWindow.Move(oldWindow.AppWindow.Position);
            _window.Activate();
            if (oldWindow != null && oldWindow != _window)
                oldWindow.Close();
        }
    }
}
