using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class StudentJson {
    [JsonPropertyName("id")]                 public int        ID                { get; set; }
    [JsonPropertyName("id_scuola")]          public string     SchoolID          { get; set; }
    [JsonPropertyName("nome")]               public string     Name              { get; set; }
    [JsonPropertyName("foto")]               public string     Photo             { get; set; }
    [JsonPropertyName("anno_corrente")]      public string     CurrentYear       { get; set; }
    [JsonPropertyName("anni")]               public List<YearJson> Years             { get; set; }
    [JsonPropertyName("scuola")]             public SchoolJson     SchoolJson            { get; set; }
    [JsonPropertyName("servizi")]            public ServicesJson   ServicesJson          { get; set; }
    [JsonPropertyName("locale")]             public string     Country           { get; set; }
    [JsonPropertyName("valuta")]             public string     Currency          { get; set; }
    [JsonPropertyName("versione_messenger")] public string     MessengerVersion  { get; set; }

    public StudentJson() { }
    public StudentJson(
        int id, 
        string schoolId, 
        string name, 
        string photo, 
        string currentYear, 
        List<YearJson> years, 
        SchoolJson schoolJson,
        ServicesJson servicesJson, 
        string country, 
        string currency, 
        string messengerVersion
        ) {
        ID               = id;
        SchoolID         = schoolId;
        Name             = name;
        Photo            = photo;
        CurrentYear      = currentYear;
        Years            = years;
        SchoolJson       = schoolJson;
        ServicesJson     = servicesJson;
        Country          = country;
        Currency         = currency;
        MessengerVersion = messengerVersion;
    }
}

