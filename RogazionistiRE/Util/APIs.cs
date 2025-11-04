using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RogazionistiRE.Util {
    public class APIs {

        public static HttpClient client = new() {
            BaseAddress = new Uri("https://rogazionisti-pd-sito.registroelettronico.com/api/"),
        };

        private static readonly string baseAPIEndpoint = "v3/scuole/rogazionisti-pd/studenti/";
        private static readonly string login = "v4/utenti/login/";

        public const string endLoginStudentInfoAPIEndpoint = "/studente/info/";
        public const string endSubjectsAPIEndpoint = "/materie_nextapi/";
        public const string endMarksAPIEndpoint = "/voti_plain/";
        public const string endHomeworkAPIEndpoint = "/compiti_plain/";
        public const string endAgendaAPIEndpoint = "/agenda_plain/";
        public const string endArgumentsAPIEndpoint = "/argomenti_plain/";
        public const string endAnnotationsAPIEndpoint = "/annotazioni_plain/";
        public const string endComunicationsThreadAPIEndpoint = "/thread/";
        public const string endComunicationsUserAPIEndpoint = "/destinatari-utente/";

        public static string getLoginAPIEndpoint() => login;
        public static string getLoginInfoStudentAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endLoginStudentInfoAPIEndpoint);
        public static string getSubjectsAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endSubjectsAPIEndpoint);
        public static string getMarksAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endMarksAPIEndpoint);
        public static string getHomeworkAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endHomeworkAPIEndpoint);
        public static string getAgendaAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endAgendaAPIEndpoint);
        public static string getArgumentsAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endArgumentsAPIEndpoint);
        public static string getAnnotationsAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endAnnotationsAPIEndpoint);
        public static string getComunicationThreadsAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endComunicationsThreadAPIEndpoint);
        public static string getComunicationUserAPIEndpoint(string loginJsonResult) => buildEndpoint(loginJsonResult, endComunicationsUserAPIEndpoint);

        static async Task PostAsync(string body, string APIEndpoint) {
            using StringContent jsonContent = new(
                body,
                Encoding.UTF8,
                "application/json");

            using HttpResponseMessage response = await client.PostAsync(
                APIEndpoint,
                jsonContent);

            response.EnsureSuccessStatusCode();
                

            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");
        }


        private static string buildEndpoint(string loginJsonResult, string endpointEnd) {
            var (idStudente, annoCorrente) = getStudentIDAndYear(loginJsonResult);
            return $"{baseAPIEndpoint}{idStudente}/{annoCorrente}{endpointEnd}";
        }

        private static (string idStudente, string annoCorrente) getStudentIDAndYear(string loginJsonResult) {
            try {
                using JsonDocument doc = JsonDocument.Parse(loginJsonResult);
                var studente = doc.RootElement.GetProperty("studenti")[0];

                var idStudente = studente.GetProperty("id").ToString();
                var annoCorrente = studente.GetProperty("anno_corrente").GetString();

                return (idStudente, annoCorrente);
            } catch (Exception ex) {
                throw new Exception($"Impossibile ottenere ID studente e anno corrente dal JSON di login.\n{ex}");
            }
        }
    }
}
