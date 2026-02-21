using RogazionistiRE.Data;
using System.IO;
using Windows.Storage;

namespace RogazionistiRE.Util;

class FileWriter {
    public const string ApplicationName = "RogazionistiRE";

    public static void aSave(string key, string content) {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        localSettings.Values[key] = content;
    }

    public static string? aRead(string key) {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        return localSettings.Values[key].ToString();
    }

    public static string? aReadRFalse(string key) {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        if (localSettings.Values[key] == null)
            return "false";
        return localSettings.Values[key].ToString();
    }
}
