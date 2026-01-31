using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace RogazionistiRE.Windows;

public class StudentsManagement {
    public static bool _demo;
    public static LoginResultJson _resultJson;
    public static ObservableCollection<Student> _students = new ObservableCollection<Student>();
    
    public static async Task load() {
        foreach (StudentJson student in _resultJson.Students) {
            _students.Add(await Student.createStudent(_resultJson.Token, student, _demo));
        }
    }
    
}

