using System;
using System.Diagnostics;
using System.IO;
using Windows.Security.Credentials;
using Windows.Storage;

namespace RogazionistiRE.Util
{
    class FileWriter
    {
        public const string ApplicationName = "RogazionistiRE";

        public static readonly string appDataPath = Path.Combine(
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
                "AppData", 
                "Roaming"),
                ApplicationName);

        public static void initializeApplicationDataFolder() {
            if (!Directory.Exists(appDataPath)) {
                createFolder(appDataPath);
            }
            Debug.WriteLine(Directory.Exists(appDataPath) ?
                $"Created application data folder at: {appDataPath}" : 
                "Some kind of error occurred! Or the folder hasn't been created");
        }

        public static void createFolder(string folderPath) {
            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
            }
        }

        public static void createFile(string filePath, string? content) {
            if (!File.Exists(filePath)) {
                File.WriteAllText(filePath, content);
            }
        }

        public static string readFile(string filePath) {
            string content;
            if (File.Exists(filePath)) {
                return File.ReadAllText(filePath);
            }
            else {
                return null;
            }
        }

        public static void deleteFile(string filePath) {
            if (File.Exists(filePath)) {
                File.Delete(filePath);
            }
        }

        public static void saveLoginData(APIRequests.LoginData loginData) {
            loginData.saveData();
        }

        public static APIRequests.LoginData getLoginData() {
            return APIRequests.LoginData.GetCredentialFromLocker();
        }

        public static void createLocalHomeWork(DirectoryInfo directoryPath, APIRequests.Homework[] homeWorks) {
            if (directoryPath == null)
                directoryPath = new DirectoryInfo(Path.Combine(appDataPath, "homeworks"));

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
                directoryPath = new DirectoryInfo(Path.Combine(appDataPath, "homeworks"));
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

        public static string convertToStringForHomeworkDoneSaves(APIRequests.Homework homework) {
            string id;

            string stringT = homework.GetTitle().ToLower();
            DateTime date = homework.GetDate();
            int subjectID = homework.GetSubjectID();
            string subjectTeacher = homework.GetTeacherName().ToLower();

            id = stringT + date.ToString() + subjectTeacher + subjectID;
            string heatlyID = FileWriter.SanitizeFileNameWithoutFullStop(id);

            return heatlyID;
        }

        public static string SanitizeFileNameWithoutFullStop(string name) {
            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');

            foreach (char c in new char[] { '.' })
                name = name.Replace(c, '_');

            return name;
        }
    }
}