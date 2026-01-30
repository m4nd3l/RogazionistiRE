using RogazionistiRE.JsonBlueprints;
using System.IO;
using Windows.Storage;

namespace RogazionistiRE.Util
{
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

        public static string aReadRFalse(string key) {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            if (localSettings.Values[key] == null)
                return "false";
            return localSettings.Values[key].ToString();
        }

        public static LoginData getLoginData() {
            return LoginData.getCredentialFromLocker();
        }

        /*public static void createLocalHomeWork(DirectoryInfo directoryPath, APIRequests.Homework[] homeWorks) {
            if (directoryPath == null)
                //directoryPath = new DirectoryInfo(Path.Combine(appDataPath, "homeworks"));

            if (!directoryPath.Exists)
                directoryPath.Create();

            for (int i = 0; i < homeWorks.Length; i++) {
                var homeWork = homeWorks[i];

                if (File.Exists(Path.Combine(directoryPath.FullName, homeWork.GetUniqueIDAsString()))) {
                    continue;
                }

                string fileName = SanitizeFileNameWithoutFullStop($"{homeWork.GetUniqueIDAsString}");
                string fileContentString = homeWork.SerializeToJsonString();
                string filePath = Path.Combine(directoryPath.FullName, fileName);

                try {
                    File.WriteAllText(filePath, fileContentString);
                }
                catch (Exception ex) {
                    Console.WriteLine($"Errore nel salvataggio di {fileName}: {ex.Message}");
                }
            }
        }

        public static void deleteLocalHomework(DirectoryInfo directoryPath) {
            if (directoryPath == null)
                // = new DirectoryInfo(Path.Combine(appDataPath, "homeworks"));
            if (!directoryPath.Exists)
                return;
            else {
                var files = directoryPath.GetFiles();
                foreach (var file in files) {
                    try {
                        file.Delete();
                    }
                    catch (Exception ex) {
                        Console.WriteLine($"Errore nella cancellazione di {file.Name}: {ex.Message}");
                    }
                }
            }
        }

        /*public static string convertToStringForHomeworkDoneSaves(APIRequests.Homework homework) {
            string id;

            string stringT = homework.GetTitle().ToLower();
            DateTime date = homework.GetDate();
            int subjectID = homework.GetSubjectID();
            string subjectTeacher = homework.GetTeacherName().ToLower();

            id = stringT + date.ToString() + subjectTeacher + subjectID;
            string heatlyID = FileWriter.SanitizeFileNameWithoutFullStop(id);

            return heatlyID;
        }*/

        public static string sanitizeFileNameWithoutFullStop(string name) {
            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');

            foreach (char c in new char[] { '.' })
                name = name.Replace(c, '_');

            return name;
        }
    }
}