using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;
public class LoginResultJson {
    [JsonPropertyName("token")]           public string            Token          { get; set; }
    [JsonPropertyName("mastercom_token")] public string            MastercomToken { get; set; }
    [JsonPropertyName("mastercom_id")]    public string            MastercomId    { get; set; }
    [JsonPropertyName("nome")]            public string            Name           { get; set; }
    [JsonPropertyName("cognome")]         public string            Surname        { get; set; }
    [JsonPropertyName("id_studente")]     public int               UserID         { get; set; }
    [JsonPropertyName("studenti")]        public List<StudentJson> Students       { get; set; }
    [JsonPropertyName("language")]        public object?           Language       { get; set; }
    [JsonPropertyName("url_scuola")]      public string            SchoolURL      { get; set; }

    public LoginResultJson() { }

    public LoginResultJson(
        string token, 
        string mastercomToken, 
        string mastercomId, 
        string name, 
        string surname, 
        int userId, 
        List<StudentJson> students, 
        object? language, 
        string schoolUrl
        ) {
        Token          = token;
        MastercomToken = mastercomToken;
        MastercomId    = mastercomId;
        Name           = name;
        Surname        = surname;
        UserID         = userId;
        Students       = students;
        Language       = language;
        SchoolURL      = schoolUrl;
    }
}

