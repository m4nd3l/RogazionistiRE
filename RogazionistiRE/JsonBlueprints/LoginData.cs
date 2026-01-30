using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using Windows.Security.Credentials;

namespace RogazionistiRE.JsonBlueprints;

    public class LoginData {
        private string _username    { get; set; }
        private string _password    { get; set; }

        public LoginData(string username, string password) {
            _username = username;
            _password = password;
        }

        public string getUserName() => _username;
        public string getPassword() => _password;
        
        #region Credential Saving System
        public void saveData() {
            var vault = new PasswordVault();
                
            try {
                vault.Remove(new PasswordCredential(FileWriter.ApplicationName, _username, _password));
            } catch { }

            vault.Add(new PasswordCredential(FileWriter.ApplicationName, _username, _password));
            FileWriter.aSave("isLoggedIn", "true");
        }
        public static LoginData getCredentialFromLocker() {
            var vault = new PasswordVault();

            IReadOnlyList<PasswordCredential> credentialList;

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
        public static void deleteData() {
            FileWriter.aSave("isLoggedIn", "false");
        }
        public static bool thereIsCredentialsInTheLocker() {
            var vault = new PasswordVault();

            try {
                var credentialList = vault.FindAllByResource(FileWriter.ApplicationName);
                return credentialList.Count > 0;
            } catch {
                return false;
            }
        }
        #endregion

        public override string ToString() {
            return $"Username: {_username}, Password: {_password}";
        }

    }