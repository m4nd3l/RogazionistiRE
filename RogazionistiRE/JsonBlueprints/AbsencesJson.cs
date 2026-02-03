using System;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class AbsencesJson {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("novita")]
        public bool New { get; set; }

        [JsonPropertyName("data")]
        public DateTime Date { get; set; }

        [JsonPropertyName("simbolo")]
        public string Symbol { get; set; }

        [JsonPropertyName("titolo")]
        public string Title { get; set; }

        [JsonPropertyName("colore_simbolo")]
        public string SymbolCOlor { get; set; }

        [JsonPropertyName("sottotitolo")]
        public object Subtitle { get; set; }

        [JsonPropertyName("giustificabile")]
        public bool Justificable { get; set; }

        [JsonPropertyName("giustificata")]
        public string Justified { get; set; }

        [JsonPropertyName("dettaglio")]
        public object Detail { get; set; }

        [JsonPropertyName("tipo_assenza")]
        public string AbscenceType { get; set; }

        [JsonPropertyName("motivazione")]
        public string Reason { get; set; }

        [JsonPropertyName("prenotazione")]
        public bool Reservation { get; set; }
}

