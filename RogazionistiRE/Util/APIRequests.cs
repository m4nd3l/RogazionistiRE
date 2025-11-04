using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Windows.Security.Credentials;

namespace RogazionistiRE.Util {
    class APIRequests {
        public class Homework {

            public int uniqueID { get; set; }
            public Subject subject { get; set; }
            public DateTime date { get; set; }
            public string title { get; set; }
            public string subTitle { get; set; }
            public string detail { get; set; }
            public string description { get; set; }
            public string module { get; set; }
            public string assignment { get; set; }

            public bool done { get; set; } = false;

            public Homework(Subject subject, DateTime date, string title,
                string subTitle = "", string detail = "", string description = "",
                string module = "", string assignment = "") {

                this.subject = subject;
                this.date = date;
                this.title = title;
                this.subTitle = subTitle;
                this.detail = detail;
                this.description = description;
                this.module = module;
                this.assignment = assignment;



            }

            public string GetSubjectName() => subject.getSubjectName();
            public string GetTeacherName() => subject.getTeacherName();
            public int GetSubjectID() => subject.getSubjectID();
            public int GetUniqueID() => uniqueID;

            public string GetUniqueIDAsString() {
                return $"{uniqueID}";
            }
            public DateTime GetDate() => date;
            public string GetTitle() => title;
            public string GetSubTitle() => subTitle;
            public string GetDetail() => detail;
            public string GetDescription() => description;
            public string GetModule() => module;
            public string GetAssignment() => assignment;


            public string SerializeToJsonString() {
                var options = new JsonSerializerOptions { WriteIndented = true };
                return JsonSerializer.Serialize(this, options);
            }
        }

        public class LoginData {
            private string _username { get; set; }
            private string _password { get; set; }

            public LoginData(string userName, string password) {
                this._username = userName;
                this._password = password;
            }

            public string GetUserName() => _username;
            public string GetPassword() => _password;

            public string login() {

                string postRequestBody = JsonSerializer.Serialize(new {
                    mastercom = "rogazionisti-pd",
                    utente = _username,
                    password = _password
                });

                string loginAPIEndpoint = APIs.getLoginAPIEndpoint();

                

                return "";
            }

            public void saveData() {
                var vault = new PasswordVault();

                try {
                    vault.Remove(new PasswordCredential(FileWriter.ApplicationName, _username, _password));
                } catch { }

                vault.Add(new PasswordCredential(FileWriter.ApplicationName, _username, _password));
            }

            public static LoginData GetCredentialFromLocker() {
                var vault = new PasswordVault();

                IReadOnlyList<PasswordCredential> credentialList = null;

                try {
                    credentialList = vault.FindAllByResource(FileWriter.ApplicationName);
                } catch (Exception) {
                    return null;
                }

                credentialList[0].RetrievePassword();


                string username = credentialList[0].UserName;
                string password = credentialList[0].Password;

                return new LoginData(username, password);
            }
        }
    }
}
