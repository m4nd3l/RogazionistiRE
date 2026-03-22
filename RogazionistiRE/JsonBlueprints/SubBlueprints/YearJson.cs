using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class YearJson : Blueprint {
    [JsonPropertyName("id")]          public string   ID          { get; set; }
    [JsonPropertyName("classe")]      public string   Class      { get; set; }
    [JsonPropertyName("indirizzo")]   public string   Address   { get; set; }
    [JsonPropertyName("descrizione")] public string   Description { get; set; }
    [JsonPropertyName("servizi")]     public ServicesJson ServicesJson     { get; set; }
    
    public override void format() {
        Class       = formatSTR(Class);
        Address     = formatSTR(Address);
        Description = formatSTR(Description);
    }
}

