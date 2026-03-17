using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    
    public sealed partial class Subjects : Page {

        public ObservableCollection<ObservableSubject> SubjectsCollection { get; set; } = new ObservableCollection<ObservableSubject>();

        public Subjects() {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e) {
            SubjectsCollection.Clear();
            var subjects = ObservableSubject.fromJsonTemplate(await ObjectManagement.getCurrentStudent().Subjects());
            foreach (var subject in subjects) 
                SubjectsCollection.Add(subject);
        }
    }
}
