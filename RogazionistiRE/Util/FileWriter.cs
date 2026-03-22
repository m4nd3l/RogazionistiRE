using RogazionistiRE.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace RogazionistiRE.Util;

class FileWriter {
    public const string ApplicationName = "RogazionistiRE";

    public static void aSave(string key, string content) {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        localSettings.Values[key] = content;
    }
    
    public static string aReadRFalse(string key) {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        if (localSettings.Values[key] == null)
            return "false";
        return localSettings.Values[key].ToString();
    }
    
    public static async Task saveJsonToFileAsync(string fileName, string jsonContent) {
        StorageFolder localFolder = ApplicationData.Current.LocalFolder;
        StorageFile file = await localFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
        await FileIO.WriteTextAsync(file, jsonContent);
    }
    
    public static string readJsonFromFileAsync(string fileName) {
        string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, fileName);
        if (File.Exists(path)) return File.ReadAllText(path);
        return "false";
    }
}
