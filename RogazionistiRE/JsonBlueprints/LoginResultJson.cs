using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;
public class LoginResultJson : Blueprint{
    [JsonPropertyName("token")]           public string            Token          { get; set; }
    [JsonPropertyName("mastercom_token")] public string            MastercomToken { get; set; }
    [JsonPropertyName("mastercom_id")]    public string            MastercomId    { get; set; }
    [JsonPropertyName("nome")]            public string            Name           { get; set; }
    [JsonPropertyName("cognome")]         public string            Surname        { get; set; }
    [JsonPropertyName("id_studente")]     public int               UserID         { get; set; }
    [JsonPropertyName("studenti")]        public List<StudentJson> Students       { get; set; }
    [JsonPropertyName("language")]        public object?           Language       { get; set; }
    [JsonPropertyName("url_scuola")]      public string            SchoolURL      { get; set; }

    public bool allNull() {
        return Token == null && 
               MastercomToken == null && 
               MastercomId == null && 
               Name == null && 
               Surname == null && 
               Students == null && 
               Language == null && 
               SchoolURL == null &&
               UserID == 0;
    }
    
    public override void format() { }
}

