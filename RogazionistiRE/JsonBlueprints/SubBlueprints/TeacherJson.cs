using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class TeacherJson : Blueprint {
    [JsonPropertyName("id")]                  public int ID              { get; set; }
    [JsonPropertyName("nome")]                public string Name         { get; set; }
    [JsonPropertyName("ordinamento")]         public int Sorting         { get; set; }
    [JsonPropertyName("titolo")]              public string Title        { get; set; }
    [JsonPropertyName("visualizza_colloqui")] public bool ViewInterviews { get; set; }
    
    public override bool Equals(object obj) {
        return obj is TeacherJson teacher &&
               teacher.ID == ID &&
               teacher.Name == Name &&
               teacher.Sorting == Sorting &&
               teacher.Title == Title &&
               teacher.ViewInterviews == ViewInterviews;
    }

    public override void format() {
        Name       = formatSTR(Name);
        Title      = formatSTR(Title);
    }
    
    public override int GetHashCode() {
        return HashCode.Combine(ID, Name, Sorting, Title, ViewInterviews);
    }
}

