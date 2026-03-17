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
public sealed partial class MoreInfoStudentContentDialog : ContentDialog {
    public MoreInfoStudentContentDialog() {
        InitializeComponent();
        string formattedName = ObjectManagement.getCurrentStudent().getFormattedName();
        Title             = formattedName;
        StudentName.Text  = $"{LanguageManager.getTranslation(LanguageKeys.Name_MoreInfoPage)}: {formattedName.ToUpper()}";
        Year.Text         = $"{LanguageManager.getTranslation(LanguageKeys.CurrentYear_MoreInfoPage)}: {ObjectManagement.getCurrentStudent()._student.CurrentYear.Replace("_", "/")}";
        Province.Text     = $"{LanguageManager.getTranslation(LanguageKeys.Province_MoreInfoPage)}: {ObjectManagement.getCurrentStudent()._student.SchoolJson.Province}";
        School.Text       = $"{LanguageManager.getTranslation(LanguageKeys.School_MoreInfoPage)}: {ObjectManagement.getCurrentStudent()._student.SchoolJson.Name}";
        StudentClass.Text = $"{LanguageManager.getTranslation(LanguageKeys.Class_MoreInfoPage)}: {ObjectManagement.getCurrentStudent().getClass()}";
        Average.Text      = $"{LanguageManager.getTranslation(LanguageKeys.AverageGrade_MoreInfoPage)}: TODO";
        Notes.Text        = $"{LanguageManager.getTranslation(LanguageKeys.Notes_MoreInfoPage)}: {ObjectManagement.getCurrentStudent().Notes().Result.Count}";
        
        CloseButtonText = LanguageManager.getTranslation(LanguageKeys.Close_MoreInfoPage);
        CornerRadius    = new CornerRadius(12);
    }
}
