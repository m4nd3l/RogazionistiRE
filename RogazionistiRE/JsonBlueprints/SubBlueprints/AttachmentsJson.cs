using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class AttachmentsJson : Blueprint{
    [JsonPropertyName("descrizione")] public string Description { get; set; }
    [JsonPropertyName("allegato")]    public string Attachment  { get; set; }
    
    public override void format() {
        Description  = formatSTR(Description);
    }
}