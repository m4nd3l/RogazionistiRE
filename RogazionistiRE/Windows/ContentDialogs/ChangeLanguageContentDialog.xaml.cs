using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using RogazionistiRE.Language;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE.Windows.ContentDialogs;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class ChangeLanguageContentDialog : ContentDialog {
    public ChangeLanguageContentDialog() {
        InitializeComponent();
        Title = LanguageManager.getTranslation(LanguageKeys.ChangeLanguage_LoginPage);
        LanguageBox.SelectedIndex = LanguageManager.getSelectedIndex();
        LanguageBox.PlaceholderText = LanguageManager.getTranslation(LanguageKeys.PickALanguage_LoginPage);
        
        CloseButtonText = LanguageManager.getTranslation(LanguageKeys.Close_MoreInfoPage);
        CornerRadius = new CornerRadius(12);
    }
    private void languageChanged(object sender, SelectionChangedEventArgs e) {
        LanguageManager.selectLanguage(LanguageBox.SelectedIndex);
        Title           = LanguageManager.getTranslation(LanguageKeys.ChangeLanguage_LoginPage);
        CloseButtonText = LanguageManager.getTranslation(LanguageKeys.Close_MoreInfoPage);
    }
}
