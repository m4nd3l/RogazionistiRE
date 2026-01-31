using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;
    
public class StudentInfoJson {
    [JsonPropertyName("periodi_scolastici")]                 public List<SchoolTermJson> SchoolTerms        { get; set; }
    [JsonPropertyName("periodo_corrente")]                   public CurrentTermJson CurrentTermJson             { get; set; }
    [JsonPropertyName("scuola")]                             public string      School                  { get; set; }
    [JsonPropertyName("voti_pesati")]                        public string      WeightedGrades          { get; set; }
    [JsonPropertyName("media_voti")]                         public string      AverageGrades           { get; set; }
    [JsonPropertyName("servizi")]                            public ServicesJson    ServicesJson                { get; set; }
    [JsonPropertyName("richiesta_colloqui_individuali")]     public bool IndividualInterviewRequest     { get; set; }
    [JsonPropertyName("prenotazione_entrate_attiva")]        public bool ActiveEnteringPrenotation      { get; set; }
    [JsonPropertyName("prenotazione_uscite_attiva")]         public bool ActiveLeavingPrenotation       { get; set; }
    [JsonPropertyName("prenotazione_entrate_orario_limite")] public string TimeLimitEnteringPrenotation { get; set; }
    [JsonPropertyName("prenotazione_uscite_orario_limite")]  public string TimeLimitLeavingPrenotation  { get; set; }
    [JsonPropertyName("indirizzo")]                          public string Address                      { get; set; }
}