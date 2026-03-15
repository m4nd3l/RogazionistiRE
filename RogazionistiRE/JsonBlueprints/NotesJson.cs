using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class NotesJson {
    [JsonPropertyName("id")]                          public int      ID                { get; set; }
    [JsonPropertyName("novita")]                      public bool     New               { get; set; }
    [JsonPropertyName("data")]                        public DateTime Date              { get; set; }
    [JsonPropertyName("titolo")]                      public string   Title             { get; set; }
    [JsonPropertyName("sottotitolo")]                 public string   Subtitle          { get; set; }
    [JsonPropertyName("presa_visione")]               public bool     Seen              { get; set; }
    [JsonPropertyName("dettaglio")]                   public object   Detail            { get; set; }
    [JsonPropertyName("colore_simbolo")]              public string   SymbolColor       { get; set; }
    [JsonPropertyName("simbolo")]                     public string   Symbol            { get; set; }
    [JsonPropertyName("tag")]                         public TagJson  Tag               { get; set; }
    [JsonPropertyName("data_presa_visione")]          public int      SeenDate          { get; set; }
    [JsonPropertyName("data_presa_visione_tradotta")] public string   TraslatedSeenDate { get; set; }
    [JsonPropertyName("url_contenuto")]               public string   ContentURL        { get; set; }
    
    public string DateFormatted  => Date.ToString("dd/HH/yyyy hh:mm");
}
