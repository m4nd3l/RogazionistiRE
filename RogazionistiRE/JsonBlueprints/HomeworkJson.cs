using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class HomeworkJson : Blueprint{
    [JsonPropertyName("id_materia")]   public int      SubjectID   { get; set; }
    [JsonPropertyName("data")]         public DateTime Date        { get; set; }
    [JsonPropertyName("titolo")]       public string   Title       { get; set; }
    [JsonPropertyName("sottotitolo")]  public string   Subtitle    { get; set; }
    [JsonPropertyName("dettaglio")]    public string   Detail      { get; set; }
    [JsonPropertyName("novita")]       public bool     New         { get; set; }
    [JsonPropertyName("descrizione")]  public string   Description { get; set; }
    [JsonPropertyName("modulo")]       public string   Module      { get; set; }
    [JsonPropertyName("assegnazioni")] public string   Assignment  { get; set; }
    
    public override void format() {
        Title         = formatSTR(Title);
        Subtitle      = formatSTR(Subtitle);
        Detail        = formatSTR(Detail);
        Module        = formatSTR(Module);
        Description   = formatSTR(Description);
        Assignment    = formatSTR(Assignment);
    }
}