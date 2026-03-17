using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;

namespace RogazionistiRE.Data;

public class ObservableHomework {
    public int      SubjectID   { get; set; }
    public DateTime Date        { get; set; }
    public string   Title       { get; set; } // Description
    public string   Subtitle    { get; set; } // Subject Name
    public string   Detail      { get; set; }
    public bool     New         { get; set; }
    public string   Description { get; set; }
    public string   Module      { get; set; }
    public string   Assignment  { get; set; }
    
    public bool     Done        { get; set; }

    public ObservableHomework(HomeworkJson json, bool done = false) {
        SubjectID   = json.SubjectID;
        Date        = json.Date;
        Title       = json.Title;
        Subtitle    = json.Subtitle;
        Detail      = json.Detail;
        New         = json.New;
        Description = json.Description;
        Module      = json.Module;
        Assignment  = json.Assignment;
        Done        = done;
    }
    
    public static ObservableCollection<ObservableHomework> merge(List<ObservableHomework> current, List<HomeworkJson> newOnes) {
        var merged = new List<ObservableHomework>(current);
        var existingKeys = new HashSet<string>(current.Select(h => $"{h.Date:yyyyMMdd}_{h.SubjectID}_{h.Title}"));
        foreach (var homework in newOnes) {
            string newKey = $"{homework.Date:yyyyMMdd}_{homework.SubjectID}_{homework.Title}";
            if (existingKeys.Contains(newKey)) continue;
            merged.Add(new ObservableHomework(homework));
        }
        merged.Sort((x, y) => x.Date.CompareTo(y.Date));
        return new ObservableCollection<ObservableHomework>(merged);
    }

    public static void save(ObservableCollection<ObservableHomework> homework, string studentID) {
        var hmList = new List<ObservableHomework>(homework);
        string serialized = JsonSerializer.Serialize(hmList);
        FileWriter.aSave(studentID, serialized);
    }

    public bool Equals(HomeworkJson other) {
        return 
            SubjectID == other.SubjectID &&
            Date.Equals(other.Date) &&
            Title == other.Title &&
            Subtitle == other.Subtitle &&
            Detail == other.Detail &&
            New == other.New &&
            Description == other.Description &&
            Module == other.Module &&
            Assignment == other.Assignment;
    }
    public bool Equals(ObservableHomework other) {
        return 
            SubjectID == other.SubjectID &&
            Date.Equals(other.Date) &&
            Title == other.Title &&
            Subtitle == other.Subtitle &&
            Detail == other.Detail &&
            New == other.New &&
            Description == other.Description &&
            Module == other.Module &&
            Assignment == other.Assignment &&
            Done == other.Done;
    }
}
