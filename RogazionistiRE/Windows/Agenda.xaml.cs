using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.Language;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE.Windows {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Agenda : Page {
        public ObservableCollection<LessonJson>         LessonsCollection     { get; set; } = new ObservableCollection<LessonJson>();
        public ObservableCollection<AgendaJson>         AgendaCollection      { get; set; } = new ObservableCollection<AgendaJson>();
        public ObservableCollection<ObservableHomework> HomeworkCollection    { get; set; } = new ObservableCollection<ObservableHomework>();
        public ObservableCollection<GradeJson>          GradesCollection      { get; set; } = new ObservableCollection<GradeJson>();
        public ObservableCollection<NotesJson>          NotesCollection       { get; set; } = new ObservableCollection<NotesJson>();
        public ObservableCollection<AnnotationJson>     AnnotationsCollection { get; set; } = new ObservableCollection<AnnotationJson>();
        public Agenda() {
            InitializeComponent();
            DateSelector.Date       =  new DateTimeOffset(DateTime.Today);
            LessonsCheckbox.Content =  LanguageManager.getTranslation(LanguageKeys.Lesson_AgendaPage);
            GradesCheckbox.Content  =  LanguageManager.getTranslation(LanguageKeys.Grade_AgendaPage);
            NotesCheckbox.Content   =  LanguageManager.getTranslation(LanguageKeys.Notes_AgendaPage);
            Loaded                  += OnLoaded;
        }
        
        private async void OnLoaded(object sender, RoutedEventArgs e) {
            await refresh();
        }
        
        private void PreviousDate_Click(object sender, RoutedEventArgs e) {
            Previous.IsEnabled = false;
            DateSelector.Date  = DateSelector.Date?.AddDays(-1);
            Previous.IsEnabled = true;
        }
        
        private void NextDate_Click(object sender, RoutedEventArgs e) {
            Next.IsEnabled = false;
            DateSelector.Date = DateSelector.Date?.AddDays(1);
            Next.IsEnabled = true;
        }
        
        private void Today_Click(object sender, RoutedEventArgs e) {
            Today.IsEnabled   = false;
            DateSelector.Date = new DateTimeOffset(DateTime.Today);
            Today.IsEnabled   = true;
        }
        
        private async void DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args) {
            if (args.NewDate != null) await refresh();
        }
        
        private async void Checkbox_Click(object sender, RoutedEventArgs e) {
            await refresh();
        }
        
        private async Task refresh() {
            string format = "dd MMMM yyyy";
            TitleDate.Text = DateSelector.Date.Value.Date.ToString(format, new CultureInfo(LanguageManager.getCultureID()));
            
            var newLessons    = ObjectManagement.getCurrentStudent().Lessons(DateSelector.Date.Value.Date);
            var newAgenda     = ObjectManagement.getCurrentStudent().Agenda(DateSelector.Date.Value.Date);
            var newHomework   = ObjectManagement.getCurrentStudent().Homework(DateSelector.Date.Value.Date);
            var newGrades     = ObjectManagement.getCurrentStudent().Grades(DateSelector.Date.Value.Date);
            var newNotes      = ObjectManagement.getCurrentStudent().Notes(DateSelector.Date.Value.Date);
            var newAnnotations= ObjectManagement.getCurrentStudent().Annotations(DateSelector.Date.Value.Date);
            
            await Task.WhenAll(newLessons, newAgenda, newHomework, newNotes, newAnnotations);
            
            UpdateCollection(LessonsCollection, LessonsCheckbox.IsChecked == false ? null : await newLessons);
            UpdateCollection(AgendaCollection, await newAgenda);
            UpdateCollection(HomeworkCollection, await newHomework);
            UpdateCollection(GradesCollection, GradesCheckbox.IsChecked == false ? null : await newGrades);
            UpdateCollection(NotesCollection, NotesCheckbox.IsChecked == false ? null : await newNotes);
            UpdateCollection(AnnotationsCollection, NotesCheckbox.IsChecked == false ? null : await newAnnotations);
        }
        
        private void UpdateCollection<T>(ObservableCollection<T> collection, IEnumerable<T>? newItems) {
            collection.Clear();
            if (newItems == null) return;
            foreach (var item in newItems) collection.Add(item);
        }
    }
}
