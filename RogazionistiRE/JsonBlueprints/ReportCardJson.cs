using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class ReportCardJson : Blueprint{
    [JsonPropertyName("novita")]      public bool                  New         { get; set; }
    [JsonPropertyName("data")]        public DateTime              Date        { get; set; }
    [JsonPropertyName("titolo")]      public string                Title       { get; set; }
    [JsonPropertyName("sottotitolo")] public string                Subtitle    { get; set; }
    [JsonPropertyName("dettaglio")]   public string                Detail      { get; set; }
    [JsonPropertyName("allegati")]    public List<AttachmentsJson> Attachments { get; set; }
    [JsonPropertyName("template")]    public string                Template    { get; set; }
    
    public override void format() {
        Title                       = formatSTR(Title);
        Subtitle                    = formatSTR(Subtitle);
        Detail                      = formatSTR(Detail);
        Template                    = formatSTR(Template);
    }
}