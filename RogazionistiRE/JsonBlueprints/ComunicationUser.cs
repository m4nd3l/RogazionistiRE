using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;
    
public class ComunicationUser {
    [JsonPropertyName("id")]          public string ID          { get; set; }
    [JsonPropertyName("id_utente")]   public string UserID      { get; set; }
    [JsonPropertyName("descrizione")] public string Description { get; set; }
    [JsonPropertyName("ordinamento")] public int    Sorting     { get; set; }
    [JsonPropertyName("gruppo")]      public string Group       { get; set; }
}