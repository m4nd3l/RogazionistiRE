using Microsoft.Windows.AppNotifications;
using Microsoft.Windows.AppNotifications.Builder;
using System.Collections.Generic;
using System.Text.Json;

namespace RogazionistiRE.Language;

public class LanguageManager {
    private static List<LanguageJson> languages = new List<LanguageJson>();
    private static int selectedLanguage = 0;

    public static void initialize() {
        LanguageJson IT = JsonSerializer.Deserialize<LanguageJson>(Languages.IT);
        LanguageJson EN = JsonSerializer.Deserialize<LanguageJson>(Languages.IT); // TODO : CHANGE TO EN
        LanguageJson ES = JsonSerializer.Deserialize<LanguageJson>(Languages.IT); // TODO : CHANGE TO ES
        LanguageJson JP = JsonSerializer.Deserialize<LanguageJson>(Languages.IT); // TODO : CHANGE TO JP
        if (EN == null || IT == null || ES == null || JP == null) {
            AppNotification notification = new AppNotificationBuilder()
                .AddText("Error")
                .AddText("An error occurred while generating the language.\nPlease send an email to mandel123e@gmail.com")
                .BuildNotification();
            AppNotificationManager.Default.Show(notification);
        }
        languages.Add(EN);
        languages.Add(IT);
        languages.Add(ES);
        languages.Add(JP);
    }
    public static string getTranslation(LanguageKeys key) { return languages[selectedLanguage].getTranslation(key); }
    public static string getTitle(LanguageKeys page) { return $"{getTranslation(LanguageKeys.RogazionistiRE_Winbar)} - {getTranslation(page)}"; }
    public static void selectLanguage(int selectedLanguageID) { selectedLanguage = selectedLanguageID; }
    public static int getSelectedIndex() {return selectedLanguage; }
}
