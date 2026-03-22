using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class SubjectJson : Blueprint {
    [JsonPropertyName("id")]                public int               ID          { get; set; }
    [JsonPropertyName("descrizione")]       public string            Description { get; set; }
    [JsonPropertyName("nome_materia_sito")] public string            SubjectName { get; set; }
    [JsonPropertyName("ordinamento")]       public int               Sorting     { get; set; }
    [JsonPropertyName("professori")]        public List<TeacherJson> Teachers    { get; set; }
    
    public ObservableCollection<TeacherJson> ObTeachers => new ObservableCollection<TeacherJson>(Teachers);

    public override void format() {
        Description = formatSTR(Description);
        SubjectName = formatSTR(SubjectName);
    }
}