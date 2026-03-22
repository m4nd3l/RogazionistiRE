using RogazionistiRE.Language;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class GradeJson : Blueprint{ 
    [JsonPropertyName("id_voto")]                     public int          GradeID               { get; set; } 
    [JsonPropertyName("id_materia")]                  public int          SubjectID             { get; set; } 
    [JsonPropertyName("data")]                        public DateTime     Date                  { get; set; } 
    [JsonPropertyName("simbolo")]                     public string       Symbol                { get; set; } 
    [JsonPropertyName("colore_simbolo")]              public string       SymbolColor           { get; set; } 
    [JsonPropertyName("novita")]                      public bool         New                   { get; set; } 
    [JsonPropertyName("titolo")]                      public string       Title                 { get; set; } 
    [JsonPropertyName("sottotitolo")]                 public string       Subtitle              { get; set; } 
    [JsonPropertyName("dettaglio")]                   public string       Detail                { get; set; } 
    [JsonPropertyName("voto_numerico")]               public double       Grade_double          { get; set; } 
    [JsonPropertyName("struttura_competenza")]        public object       CompetenceStructure   { get; set; } 
    [JsonPropertyName("note_competenza")]             public object       CompetenceNote        { get; set; } 
    [JsonPropertyName("descrizione_peso")]            public object       DescriptionWeight     { get; set; } 
    [JsonPropertyName("valore_peso")]                 public object       ValueWeight           { get; set; } 
    [JsonPropertyName("voto_pesato")]                 public bool         WheightedGrade        { get; set; } 
    [JsonPropertyName("dimensioni")]                  public List<object> Dimensions            { get; set; } 
    [JsonPropertyName("descrizione_competenza")]      public object       CompetenceDescription { get; set; } 
    [JsonPropertyName("data_presa_visione")]          public int          SeenDate              { get; set; } 
    [JsonPropertyName("data_presa_visione_tradotta")] public string       TranslatedSeenDate    { get; set; } 
    [JsonPropertyName("url_contenuto")]               public string       ContentURL            { get; set; } 
    [JsonPropertyName("presa_visione")]               public bool         Seen                  { get; set; } 
    [JsonPropertyName("is_voto")]                     public bool         IsGrade               { get; set; } 
    [JsonPropertyName("is_competenza")]               public bool         IsCompetence          { get; set; }
    public string DateFormatted => Date.ToString("dd/HH/yyyy hh:mm");
    public string MarginIfText => Detail == "" ? "0" : "12,12,12,8";
    public string GradeTranslated => LanguageManager.getTranslation(LanguageKeys.Grade_AgendaPage);
    
    public override void format() {
        Title              = formatSTR(Title);
        Subtitle           = formatSTR(Subtitle);
        Detail             = formatSTR(Detail);
        TranslatedSeenDate = formatSTR(TranslatedSeenDate);
    }
}

