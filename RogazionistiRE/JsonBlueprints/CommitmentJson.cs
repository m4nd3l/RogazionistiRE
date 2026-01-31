using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class CommitmentJson {
    [JsonPropertyName("id")]          public int      ID        { get; set; }
    [JsonPropertyName("id_materia")]  public object   SubjectID { get; set; }
    [JsonPropertyName("novita")]      public bool     New       { get; set; }
    [JsonPropertyName("data")]        public DateTime Date      { get; set; }
    [JsonPropertyName("data_fine")]   public DateTime FinalDate { get; set; }
    [JsonPropertyName("titolo")]      public string   Title     { get; set; }
    [JsonPropertyName("sottotitolo")] public string   Subtitle  { get; set; }
    [JsonPropertyName("dettaglio")]   public string   Detail    { get; set; }
}

