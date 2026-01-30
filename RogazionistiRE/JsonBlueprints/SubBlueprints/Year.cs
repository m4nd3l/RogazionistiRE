using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class Year {
    [JsonPropertyName("id")]          public string   ID          { get; set; }
    [JsonPropertyName("id_classe")]   public string   Class      { get; set; }
    [JsonPropertyName("indirizzo")]   public string   Address   { get; set; }
    [JsonPropertyName("descrizione")] public string   Description { get; set; }
    [JsonPropertyName("servizi")]     public Services Services     { get; set; }
}

