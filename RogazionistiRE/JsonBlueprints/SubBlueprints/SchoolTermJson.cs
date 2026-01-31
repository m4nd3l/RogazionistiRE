using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class SchoolTermJson {
    [JsonPropertyName("periodo")]     public string   Term          { get; set; }
    [JsonPropertyName("numero")]      public int      Number        { get; set; }
    [JsonPropertyName("data_inizio")] public DateTime StartingDate  { get; set; }
    [JsonPropertyName("data_fine")]   public DateTime FinishingDate { get; set; }
}