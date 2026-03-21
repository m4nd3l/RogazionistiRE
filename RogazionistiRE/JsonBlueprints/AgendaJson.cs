using RogazionistiRE.Language;
using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class AgendaJson {
    [JsonPropertyName("id")]          public int      ID              { get; set; }
    [JsonPropertyName("id_materia")]  public object   SubjectID       { get; set; }
    [JsonPropertyName("novita")]      public bool     New             { get; set; }
    [JsonPropertyName("data")]        public DateTime Date            { get; set; }
    [JsonPropertyName("data_fine")]   public DateTime FinalDate       { get; set; }
    [JsonPropertyName("titolo")]      public string   Title           { get; set; }
    [JsonPropertyName("sottotitolo")] public string   Subtitle        { get; set; }
    [JsonPropertyName("dettaglio")]   public string   Detail          { get; set; }
    public                                   string   DateFormatted   => Date.ToString("dd/HH/yyyy hh:mm");
    public                                   string   MarginIfText    => Subtitle == "" ? "0" : "12,12,12,8";
    public                                   string   EventTranslated => LanguageManager.getTranslation(LanguageKeys.Event_AgendaPage);
}

