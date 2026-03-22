using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class TagJson : Blueprint{
    [JsonPropertyName("codice")]      public string Code        { get; set; }
    [JsonPropertyName("descrizione")] public string Description { get; set; }
    [JsonPropertyName("ordinamento")] public string Sorting     { get; set; }
    
    public override void format() {
        Description = formatSTR(Description);
    }
}