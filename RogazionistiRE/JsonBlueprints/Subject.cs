using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints;

public class Subject {
    [JsonPropertyName("id")]                public int           ID          { get; set; }
    [JsonPropertyName("descrizione")]       public string        Description { get; set; }
    [JsonPropertyName("nome_materia_sito")] public string        SubjectName { get; set; }
    [JsonPropertyName("ordinamento")]       public int           Sorting     { get; set; }
    [JsonPropertyName("professori")]        public List<Teacher> Teachers    { get; set; }
}

