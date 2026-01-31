using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class AttachmentsJson {
    [JsonPropertyName("descrizione")] public string Description { get; set; }
    [JsonPropertyName("allegato")]    public string Attachment  { get; set; }
}