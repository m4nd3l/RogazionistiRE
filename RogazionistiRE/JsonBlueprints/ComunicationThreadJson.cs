using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;
    
public class ComunicationThreadJson {
    [JsonPropertyName("id")]                      public string   ID                  { get; set; }
    [JsonPropertyName("id_materia")]              public int      SubjectID           { get; set; }
    [JsonPropertyName("novita")]                  public bool     New                 { get; set; }
    [JsonPropertyName("data")]                    public DateTime Date                { get; set; }
    [JsonPropertyName("titolo")]                  public string   Title               { get; set; }
    [JsonPropertyName("sottotitolo")]             public string   Subtitle            { get; set; }
    [JsonPropertyName("mittente")]                public SenderJson SenderJson                { get; set; }
    [JsonPropertyName("presa_visione")]           public int      Seen                { get; set; }
    [JsonPropertyName("da_leggere")]              public bool     ToRead              { get; set; }
    [JsonPropertyName("data_lettura")]            public DateTime ReadingDate         { get; set; }
    [JsonPropertyName("data_presa_visione")]      public object SeenDate              { get; set; }
    [JsonPropertyName("sottoscrizione")]          public int    Subscription          { get; set; }
    [JsonPropertyName("allegati")]                public int    Attachments           { get; set; }
    [JsonPropertyName("tipo_messaggio")]          public string MessageType           { get; set; }
    [JsonPropertyName("destinatari_concatenati")] public string ConcatenatedRecipient { get; set; }
    [JsonPropertyName("conferma_lettura")]        public bool ConfirmReading          { get; set; }
    [JsonPropertyName("id_messaggio")]            public int  MessageID               { get; set; }
}