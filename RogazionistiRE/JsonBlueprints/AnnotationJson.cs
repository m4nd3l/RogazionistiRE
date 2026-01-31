using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints ;

public class AnnotationJson {
    [JsonPropertyName("id_materia")]          public int      SubjectID       { get; set; }
    [JsonPropertyName("data")]                public DateTime Data            { get; set; }
    [JsonPropertyName("simbolo")]             public string   Symbol          { get; set; }
    [JsonPropertyName("descrizione_simbolo")] public string SymbolDescription { get; set; }
    [JsonPropertyName("colore_simbolo")]      public string SymbolColor       { get; set; }
    [JsonPropertyName("novita")]              public bool   New               { get; set; }
    [JsonPropertyName("titolo")]              public string Title             { get; set; }
    [JsonPropertyName("sottotitolo")]         public string Subtitle          { get; set; }
    [JsonPropertyName("dettaglio")]           public string Detail            { get; set; }
}
