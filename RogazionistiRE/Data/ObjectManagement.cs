using RogazionistiRE.Data;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace RogazionistiRE.Windows;

public class ObjectManagement {
    public static bool _demo;
    public static LoginResultJson? _resultJson = null;
    public static ObservableCollection<Student> _students = new ObservableCollection<Student>();
    private static int currentStudentIndex;
    
    public static async Task load() {
        if (_students.Count != 0) return;
        foreach (StudentJson student in _resultJson.Students) {
            Student obj = await Student.createStudent(_resultJson.Token, $"{student.ID}", student);
            if (_students.Contains(obj)) continue;
            _students.Add(obj);
        }
    }

    public static void selectStudent(Student student) {
        currentStudentIndex = _students.IndexOf(student);
    }

    public static Student getCurrentStudent() {
        return _students[currentStudentIndex];
    }

    public static void resetCurrentStudent() {
        currentStudentIndex = -1;
    }
    
    public static async Task close() {
        foreach (Student student in _students) await student.save();
    }
}

