using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using RogazionistiRE.Language;
using RogazionistiRE.Windows.ContentDialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE.Windows {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page {
        public string TitleBarName() => $"{LanguageManager.getTranslation(LanguageKeys.RogazionistiRE_Winbar)} - {ObjectManagement.getCurrentStudent()._student.Name}";
        public Home() {
            InitializeComponent();
            Title.Text = $"{ObjectManagement.getCurrentStudent().getName()}";
            ContentFrame.Navigate(typeof(Overview));
            OverviewItem.Content       = LanguageManager.getTranslation(LanguageKeys.Home_StudentPage);
            GradesItem.Content         = LanguageManager.getTranslation(LanguageKeys.Grades_StudentPage);
            AgendaItem.Content         = LanguageManager.getTranslation(LanguageKeys.Agenda_StudentPage);
            AbsencesItem.Content       = LanguageManager.getTranslation(LanguageKeys.Absences_StudentPage);
            NotesItem.Content          = LanguageManager.getTranslation(LanguageKeys.Notes_StudentPage);
            CommunicationsItem.Content = LanguageManager.getTranslation(LanguageKeys.Communications_StudentPage);
            ReportCardsItem.Content    = LanguageManager.getTranslation(LanguageKeys.ReportCards_StudentPage);
            SubjectsItem.Content       = LanguageManager.getTranslation(LanguageKeys.Subjects_StudentPage);
            MoreInfoItem.Content       = LanguageManager.getTranslation(LanguageKeys.MoreInfo_StudentPage);
        }
        
        private async void NavViewSelection(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            if (!(args.SelectedItem is NavigationViewItem)) return;
            start();
            var item = args.SelectedItem as NavigationViewItem;
            await ObjectManagement.getCurrentStudent().Info();
            await ObjectManagement.getCurrentStudent().Subjects();
            switch (item.Tag.ToString()) {
                case "Overview":
                    await ObjectManagement.getCurrentStudent().ComunicationThread();
                    await ObjectManagement.getCurrentStudent().ComunicationUser();
                    Title.Text = $"{ObjectManagement.getCurrentStudent().getName()}";
                    ContentFrame.Navigate(typeof(Overview));
                    break;
                
                case "Grades":
                    await ObjectManagement.getCurrentStudent().Grades();
                    Title.Text = LanguageManager.getTranslation(LanguageKeys.Grades_StudentPage);
                    ContentFrame.Navigate(typeof(Grades));
                    break;
                
                case "Agenda":
                    await ObjectManagement.getCurrentStudent().Lessons();
                    await ObjectManagement.getCurrentStudent().Agenda();
                    await ObjectManagement.getCurrentStudent().Homework();
                    await ObjectManagement.getCurrentStudent().Grades();
                    await ObjectManagement.getCurrentStudent().Notes();
                    await ObjectManagement.getCurrentStudent().Annotations();
                    Title.Text = LanguageManager.getTranslation(LanguageKeys.Agenda_StudentPage);
                    ContentFrame.Navigate(typeof(Agenda));
                    break;
                
                case "Absences":
                    await ObjectManagement.getCurrentStudent().Absences();
                    Title.Text = LanguageManager.getTranslation(LanguageKeys.Absences_StudentPage);
                    ContentFrame.Navigate(typeof(Absences));
                    break;
                
                case "Notes":
                    await ObjectManagement.getCurrentStudent().Notes();
                    await ObjectManagement.getCurrentStudent().Annotations();
                    Title.Text = LanguageManager.getTranslation(LanguageKeys.Notes_StudentPage);
                    ContentFrame.Navigate(typeof(Annotations));
                    break;
                
                case "Communications":
                    await ObjectManagement.getCurrentStudent().ComunicationThread();
                    await ObjectManagement.getCurrentStudent().ComunicationUser();
                    Title.Text = LanguageManager.getTranslation(LanguageKeys.Communications_StudentPage);
                    ContentFrame.Navigate(typeof(Comunications));
                    break;
                
                case "ReportCards":
                    await ObjectManagement.getCurrentStudent().ReportCards();
                    Title.Text = LanguageManager.getTranslation(LanguageKeys.ReportCards_StudentPage);
                    ContentFrame.Navigate(typeof(ReportCards));
                    break;
                
                case "Subjects":
                    Title.Text = LanguageManager.getTranslation(LanguageKeys.Subjects_StudentPage);
                    ContentFrame.Navigate(typeof(Subjects));
                    break;
                
                case "Info":
                    stop();
                    await ObjectManagement.getCurrentStudent().Notes();
                    await ObjectManagement.getCurrentStudent().Grades();
                    MoreInfoStudentContentDialog dialog = new MoreInfoStudentContentDialog() { XamlRoot = XamlRoot, };
                    await dialog.ShowAsync();
                    break;
            }
            stop();
        }
        private async void BackToStudents(NavigationView sender, NavigationViewBackRequestedEventArgs args) {
            ObjectManagement.resetCurrentStudent();
            var page = new Students(null);
            await page.init();
            App.switchPage(page);
        }
        
        private void start() {
            LoadingText.Text = LanguageManager.getTranslation(LanguageKeys.Loading_General);
            FadeInOverlay.Begin();
        }

        private void stop() {
            FadeOutOverlay.Begin();
        }
    }
}
