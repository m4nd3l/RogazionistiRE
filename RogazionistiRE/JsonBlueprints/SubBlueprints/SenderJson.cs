using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class SenderJson {
    [JsonPropertyName("id_mittente")] public object SenderID { get; set; }
    [JsonPropertyName("cognome")]     public string Surname  { get; set; }
    [JsonPropertyName("nome")]        public string Name     { get; set; }
}