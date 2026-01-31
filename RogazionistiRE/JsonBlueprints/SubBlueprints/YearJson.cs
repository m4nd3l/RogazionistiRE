using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class YearJson {
    [JsonPropertyName("id")]          public string   ID          { get; set; }
    [JsonPropertyName("classe")]   public string   Class      { get; set; }
    [JsonPropertyName("indirizzo")]   public string   Address   { get; set; }
    [JsonPropertyName("descrizione")] public string   Description { get; set; }
    [JsonPropertyName("servizi")]     public ServicesJson ServicesJson     { get; set; }

    public YearJson() { }

    public YearJson(
            string id, 
            string @class, 
            string address, 
            string description, 
            ServicesJson servicesJson
        ) {
        ID           = id;
        Class        = @class;
        Address      = address;
        Description  = description;
        ServicesJson = servicesJson;
    }

}

