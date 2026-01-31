using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class SchoolJson {
    [JsonPropertyName("mastercom_id")] public string  MastercomID  { get; set; }
    [JsonPropertyName("nome")]         public string  Name         { get; set; }
    [JsonPropertyName("url_quaderno")] public string  NotebookURL  { get; set; }
    [JsonPropertyName("url_registro")] public string  RegistryURL  { get; set; }
    [JsonPropertyName("url_scuola")]   public string  SchoolURL    { get; set; }
    [JsonPropertyName("provincia")]    public string  Province     { get; set; }
    [JsonPropertyName("logo")]         public object? Logo         { get; set; }
    [JsonPropertyName("comune")]       public string  Municipality { get; set; }
    [JsonPropertyName("tipo")]         public string  Type         { get; set; }

    public SchoolJson() { }
    public SchoolJson(
        string mastercomId,
        string name,
        string notebookUrl,
        string registryUrl,
        string schoolUrl,
        string province,
        object? logo,
        string municipality,
        string type
        ) {
        MastercomID  = mastercomId;
        Name         = name;
        NotebookURL  = notebookUrl;
        RegistryURL  = registryUrl;
        SchoolURL    = schoolUrl;
        Province     = province;
        Logo         = logo;
        Municipality = municipality;
        Type         = type;
    }

}

