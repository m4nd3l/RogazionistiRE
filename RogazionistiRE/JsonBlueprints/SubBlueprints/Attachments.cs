using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class Attachments {
    [JsonPropertyName("descrizione")] public string Description { get; set; }
    [JsonPropertyName("allegato")]    public string Attachment  { get; set; }
}