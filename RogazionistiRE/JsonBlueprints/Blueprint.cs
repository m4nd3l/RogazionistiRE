using System.Collections.Generic;

namespace RogazionistiRE.JsonBlueprints;

public abstract class Blueprint {
    public string formatSTR(string text) {
        if (string.IsNullOrEmpty(text)) return text;
        
        var replacements = new Dictionary<string, string> {
            { "\\u0026ograve;", "ò" },
            { "\\u0026Igrave;", "Ì" },
            { "\\u0026agrave;", "à" },
            { "\\u0026egrave;", "è" },
            { "\\u0026ldquo;",  "“" },
            { "\\u0026rdquo;",  "”" },
            { "\\u0026rsquo;",  "’" },
            { "\\u0026quot;",   "\"" },
            { "\\u0026#039;",   "'" }
        };

        foreach (var entry in replacements) text = text.Replace(entry.Key, entry.Value);
        
        return text;
    }
    public abstract void format();
}
