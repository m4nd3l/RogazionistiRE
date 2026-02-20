using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RogazionistiRE.Language;

public class LanguageJson {
    [JsonPropertyName("name")]         public string Name { get; set; }
    [JsonPropertyName("translations")] public Dictionary<string, string> Translations { get; set; }

    public string getTranslation(LanguageKeys key) {
        return Translations.GetValueOrDefault(key.ToString(), "Unknown");
    }
}
