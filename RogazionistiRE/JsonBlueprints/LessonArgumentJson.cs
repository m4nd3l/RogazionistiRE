using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class LessonArgumentJson {
    [JsonPropertyName("id_materia")]  public int      SubjectID { get; set; }
    [JsonPropertyName("data")]        public DateTime Date      { get; set; }
    [JsonPropertyName("titolo")]      public string   Title     { get; set; }
    [JsonPropertyName("sottotitolo")] public string   Subtitle  { get; set; }
    [JsonPropertyName("dettaglio")]   public string   Detail    { get; set; }
    [JsonPropertyName("novita")]      public bool     New       { get; set; }
    [JsonPropertyName("modulo")]      public string   Module    { get; set; }
}