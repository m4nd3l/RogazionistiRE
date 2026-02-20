using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace RogazionistiRE.Util;

public class ObservableSubject {
    public int                               ID          { get; set; }
    public string                            Description { get; set; }
    public string                            SubjectName { get; set; }
    public int                               Sorting     { get; set; }
    public ObservableCollection<TeacherJson> Teachers    { get; set; } = new();

    public ObservableSubject(int id, string description, string subjectName, int sorting) {
        ID          = id;
        Description = description;
        SubjectName = subjectName;
        Sorting     = sorting;
    }

    public ObservableSubject addTeachers(ObservableCollection<TeacherJson> teachers) {
        Teachers = teachers;
        return this;
    }

    public static ObservableCollection<ObservableSubject> fromJsonTemplate(List<SubjectJson> subjects) {
        var result = new ObservableCollection<ObservableSubject>();
        foreach (var subject in subjects) {
            result.Add(new ObservableSubject(subject.ID, subject.Description, subject.SubjectName, subject.Sorting)
                           .addTeachers(new ObservableCollection<TeacherJson>(subject.Teachers.Distinct().ToList())));
        }
        return result;
    }

}