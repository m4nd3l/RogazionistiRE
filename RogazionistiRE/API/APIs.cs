using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RogazionistiRE.Util {
    public class APIs {

        public static HttpClient client = new() { BaseAddress = new Uri("https://rogazionisti-pd-sito.registroelettronico.com/api/"), };

        private static readonly string baseAPIEndpoint = "v3/scuole/rogazionisti-pd/studenti/";
        private static readonly string login = "v4/utenti/login-web/";

        public const string endLoginStudentInfoAPIEndpoint = "/studente/info/";
        public const string endSubjectsAPIEndpoint = "/materie_nextapi/";
        public const string endGradesAPIEndpoint = "/voti_plain/";
        public const string endHomeworkAPIEndpoint = "/compiti_plain/";
        public const string endAgendaAPIEndpoint = "/agenda_plain/";
        public const string endArgumentsAPIEndpoint = "/argomenti_plain/";
        public const string endAnnotationsAPIEndpoint = "/annotazioni_plain/";
        public const string endNotesAPIEndpoint = "/note_plain//";
        public const string endComunicationsThreadAPIEndpoint = "/thread/";
        public const string endComunicationsUserAPIEndpoint = "/destinatari-utente/";
        public const string endReportCardAPIEndpoint = "/pagelle_plain/";
        public const string endAbsencesAPIEndpoint = "/assenze_plain/";

        public static string getLoginAPIEndpoint() => login;
        public static string getLoginInfoStudentAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endLoginStudentInfoAPIEndpoint);
        public static string getSubjectsAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endSubjectsAPIEndpoint);
        public static string getGradesAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endGradesAPIEndpoint);
        public static string getHomeworkAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endHomeworkAPIEndpoint);
        public static string getAgendaAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endAgendaAPIEndpoint);
        public static string getArgumentsAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endArgumentsAPIEndpoint);
        public static string getAnnotationsAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endAnnotationsAPIEndpoint);
        public static string getNotesAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endNotesAPIEndpoint);
        public static string getComunicationThreadsAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endComunicationsThreadAPIEndpoint);
        public static string getComunicationsUserAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endComunicationsUserAPIEndpoint);
        public static string getReportCardAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endReportCardAPIEndpoint);
        public static string getAbsencesAPIEndpoint(StudentJson studentJson) => buildEndpoint(studentJson, endAbsencesAPIEndpoint);

        public static async Task<string> getAsync(string APIEndpoint, string token) {
            var request = new HttpRequestMessage(HttpMethod.Get, APIEndpoint);

            request.Headers.Add("Authorization", $"JWT {token}");

            using HttpResponseMessage response = await client.SendAsync(request);

            try { response.EnsureSuccessStatusCode(); } 
            catch (HttpRequestException ex) { Debug.WriteLine($"Error during the GET request to {APIEndpoint} endpoint.\nMore info:\n{ex}"); }

            return await response.Content.ReadAsStringAsync();
        }
        public static async Task<string> postAsync(string body, string APIEndpoint) {
            using var jsonContent = new StringContent(
                body,
                Encoding.UTF8,
                "application/json");

            using HttpResponseMessage response = await client.PostAsync(APIEndpoint, jsonContent);

            try { response.EnsureSuccessStatusCode(); } 
            catch (HttpRequestException ex) { Debug.WriteLine($"Error during the POST request to {APIEndpoint} endpoint.\nMore info:\n{ex}"); }
            
            return await response.Content.ReadAsStringAsync();
        }


        private static string buildEndpoint(StudentJson studentJson, string endpointEnd) {
            var (StudentID, currentYear) = getStudentIDAndYear(studentJson);
            return $"{baseAPIEndpoint}{StudentID}/{currentYear}{endpointEnd}";
        }

        private static (int StudentID, string currentYear) getStudentIDAndYear(StudentJson studentJson) {
            return (studentJson.ID, studentJson.CurrentYear);
        }
    }
}
