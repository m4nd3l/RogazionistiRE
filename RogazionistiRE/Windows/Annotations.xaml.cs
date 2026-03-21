using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using RogazionistiRE.JsonBlueprints;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RogazionistiRE.Windows {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Annotations : Page {
        public ObservableCollection<NotesJson>      NotesCollection       { get; set; } = new  ObservableCollection<NotesJson>();
        public ObservableCollection<AnnotationJson> AnnotationsCollection { get; set; } = new  ObservableCollection<AnnotationJson>();
        public Annotations() {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e) {
            NotesCollection = await ObjectManagement.getCurrentStudent().Notes();
            AnnotationsCollection = await ObjectManagement.getCurrentStudent().Annotations();
        }
    }
}
