using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Language;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;

namespace RogazionistiRE.Windows {
    public sealed partial class Students : Page {
        public ObservableCollection<Student> DisplayedStudents { get; set; } = new();
        
        public Students(LoginResultJson resultJson, bool demo = false) {
            InitializeComponent();
            
            if (ObjectManagement._resultJson == null)
                ObjectManagement._resultJson = resultJson;
            
            ObjectManagement._demo = demo;
            
            TitleBar.Title         = LanguageManager.getTitle(LanguageKeys.Students_StudentsPage);
            Search.PlaceholderText = LanguageManager.getTitle(LanguageKeys.SearchStudents_StudentsPage);
            SettingsButton.Label   = LanguageManager.getTranslation(LanguageKeys.Settings_StudentsPage);
            LogoutButton.Label     = LanguageManager.getTranslation(LanguageKeys.Logout_StudentsPage);
            Title.Text             = LanguageManager.getTranslation(LanguageKeys.Students_StudentsPage);
            
            string fullParentName = formatName(ObjectManagement._resultJson.Name + " " + ObjectManagement._resultJson.Surname);
            Welcome.Text = LanguageManager.getTranslation(LanguageKeys.Welcome_StudentsPage).Replace("[%PARENT_NAME%]", fullParentName);
        }

        public async Task init() {
            await ObjectManagement.load();
            RefreshDisplayList();
        }
        
        private void RefreshDisplayList(string filter = "") {
            DisplayedStudents.Clear();
            
            foreach (var student in ObjectManagement._students) {
                if (string.IsNullOrWhiteSpace(filter) || 
                    student._student.Name.Contains(filter, StringComparison.OrdinalIgnoreCase)) {
                    DisplayedStudents.Add(student);
                }
            }
        }
        
        private void StudentSearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args) {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput) RefreshDisplayList(sender.Text);
        }

        private string formatName(string name) {
            if (string.IsNullOrWhiteSpace(name)) return name;
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(name.ToLower());
        }

        private void logout(object sender, RoutedEventArgs e) {
            LoginData.deleteData();
            App._login = null;
            ObjectManagement._resultJson = null;
            ObjectManagement._demo = false;
            ObjectManagement._students = new ObservableCollection<Student>();  
            App.switchToLoginWindow();
        }

        private void studentPressed(ItemsView sender, ItemsViewItemInvokedEventArgs args) {
            if (args.InvokedItem is Student student) {
                ObjectManagement.selectStudent(student);
                App.switchPage(new Home());
            }
        }
        
        private void SettingsPointerEntered(object sender, PointerRoutedEventArgs e) {
            AnimatedIcon.SetState(SettingsIcon, "PointerOver");
        }

        private void ButtonPointerExited(object sender, PointerRoutedEventArgs e) {
            AnimatedIcon.SetState(SettingsIcon, "Normal");
        }

        private void Settings(object sender, RoutedEventArgs e) {
            Debug.WriteLine("Settings Clicked");
        }
    }
}