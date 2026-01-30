using RogazionistiRE.JsonBlueprints;
using System.IO;
using Windows.Storage;

namespace RogazionistiRE.Util;

class FileWriter
{
    public const string ApplicationName = "RogazionistiRE";

    public static void saveLoginData(LoginData loginData) {
        loginData.saveData();
    }

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

    public static LoginData? getLoginData() {
        return LoginData.getCredentialFromLocker();
    }
    
    public static string sanitizeFileNameWithoutFullStop(string name) {
        foreach (char c in Path.GetInvalidFileNameChars())
            name = name.Replace(c, '_');

        foreach (char c in new char[] { '.' })
            name = name.Replace(c, '_');

        return name;
    }
}
