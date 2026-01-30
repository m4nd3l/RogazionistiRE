using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class School {
    [JsonPropertyName("mastercom_id")] public string MastercomID { get; set; }
    [JsonPropertyName("nome")]         public string Name        { get; set; }
    [JsonPropertyName("url_quaderno")] public string NotebookURL { get; set; }
    [JsonPropertyName("url_registro")] public string RegistryURL { get; set; }
    [JsonPropertyName("url_scuola")]   public string SchoolURL   { get; set; }
    [JsonPropertyName("provincia")]    public string Province    { get; set; }
    [JsonPropertyName("logo")]         public object Logo         { get; set; }
    [JsonPropertyName("comune")]       public string Municipality { get; set; }
    [JsonPropertyName("tipo")]         public string Type         { get; set; }
}

