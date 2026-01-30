using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class Student {
    [JsonPropertyName("id")]                 public int        ID                { get; set; }
    [JsonPropertyName("id_scuola")]          public string     SchoolID          { get; set; }
    [JsonPropertyName("nome")]               public string     Name              { get; set; }
    [JsonPropertyName("foto")]               public string     Photo             { get; set; }
    [JsonPropertyName("anno_corrente")]      public string     CurrentYear       { get; set; }
    [JsonPropertyName("anni")]               public List<Year> Years             { get; set; }
    [JsonPropertyName("scuola")]             public School     School            { get; set; }
    [JsonPropertyName("servizi")]            public Services   Services          { get; set; }
    [JsonPropertyName("locale")]             public string     Country           { get; set; }
    [JsonPropertyName("valuta")]             public string     Currency          { get; set; }
    [JsonPropertyName("versione_messenger")] public string     MessengerVersion  { get; set; }
}

