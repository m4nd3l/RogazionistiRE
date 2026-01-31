using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class TeacherJson {
    [JsonPropertyName("id")]                  public int ID              { get; set; }
    [JsonPropertyName("nome")]                public string Name         { get; set; }
    [JsonPropertyName("ordinamento")]         public int Sorting         { get; set; }
    [JsonPropertyName("titolo")]              public string Title        { get; set; }
    [JsonPropertyName("visualizza_colloqui")] public bool ViewInterviews { get; set; }
}

