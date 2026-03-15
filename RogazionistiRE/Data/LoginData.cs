using Microsoft.Windows.AppNotifications;
using Microsoft.Windows.AppNotifications.Builder;
using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.Security.Credentials;

namespace RogazionistiRE.Data;

public class LoginData {
    private string _username    { get; set; }
    private string _password    { get; set; }

    public LoginData(string username, string password) {
        _username = username;
        _password = password;
    }

    public string getUserName() => _username;
    public string getPassword() => _password;
    
    #region Login
    public async Task<(LoginResultJson? result, bool succeded)> login() {
        // Gets the endpoint and creates the body
        string loginEndpoint = APIs.getLoginAPIEndpoint();
        var payload = new { mastercom = "rogazionisti-pd", utente = getUserName(), password = getPassword() };
        string bodyRequest = JsonSerializer.Serialize(payload);
        // Makes the request and check for errors
        string jsonResult = await APIs.postAsync(bodyRequest, loginEndpoint);
        if (jsonResult.ToLower().Contains("error")) {
            Debug.WriteLine($"Couldn't login.\nMore info:\n{jsonResult}");
            return (null, false);
        }
        // Converts json into a LoginResult object
        LoginResultJson? result = JsonSerializer.Deserialize<LoginResultJson>(jsonResult);
        if (result == null) {
            Debug.WriteLine($"Couldn't serialize result into a LoginResult object.\nJson received:\n{jsonResult}");
            return (null, false);
        }
        if (result.allNull()) {
            Debug.WriteLine($"Couldn't serialize result into a LoginResult object.\nJson received:\n{jsonResult}");
            return (null, false);
        }
        return (result, true);
    }

    public LoginResultJson? demoLogin() {
        LoginResultJson? result = JsonSerializer.Deserialize<LoginResultJson>(DemoJsons.LOGIN_JSON);
        if (result == null) {
            Debug.WriteLine($"Couldn't serialize result into a LoginResult object.\nJson:\n{DemoJsons.LOGIN_JSON}");
            return null;
        }
        return result;
    }
    #endregion
    
    #region Credential Saving System
    public void saveData() {
        clearAllAppCredentials();
        var vault = new PasswordVault();

        try {
            var existing = vault.Retrieve(FileWriter.ApplicationName, _username);
            if (existing != null) vault.Remove(existing);
        } catch { /* Credential doesn't exist, ignore */ }

        vault.Add(new PasswordCredential(FileWriter.ApplicationName, _username, _password));
        FileWriter.aSave("isLoggedIn", "true");
    }
    
    public static LoginData? getCredentialFromLocker() {
        var vault = new PasswordVault();
    
        try {
            var credentialList = vault.FindAllByResource(FileWriter.ApplicationName);
        
            if (credentialList.Count > 0) {
                var mostRecent = credentialList.Last(); 
            
                mostRecent.RetrievePassword();
                return new LoginData(mostRecent.UserName, mostRecent.Password);
            }
        } catch (Exception exception) {
            notify("Error!", $"Raised an exception while retrieving the login data.\nMore info:\n{exception}"); 
            FileWriter.aSave("isLoggedIn", "false");
        }

        return null;
    }
    
    public static void deleteData() {
        clearAllAppCredentials();
        FileWriter.aSave("isLoggedIn", "false");
    }
    
    public static bool credentialsInTheLocker() {
        var vault = new PasswordVault();

        try {
            var credentialList = vault.FindAllByResource(FileWriter.ApplicationName);
            return credentialList.Count > 0;
        } catch { return false; }
    }
    
    public static void clearAllAppCredentials()
    {
        var vault = new PasswordVault();
        try
        {
            // 1. Get every credential associated with your App Name
            var credentialList = vault.FindAllByResource(FileWriter.ApplicationName);

            // 2. Loop through and remove every single one
            foreach (var credential in credentialList)
            {
                vault.Remove(credential);
                Debug.WriteLine($"Deleted credential for user: {credential.UserName}");
            }
        
            // 3. Reset your login flag so the app knows it's empty
            FileWriter.aSave("isLoggedIn", "false");
            Debug.WriteLine("Vault successfully cleared.");
        } catch { }
    }
    #endregion

    public override string ToString() {
        return $"Username: {_username}, Password: {_password}";
    }

    private static void notify(string title, string msg) {
        AppNotification notification = new AppNotificationBuilder()
            .AddText(title)
            .AddText(msg)
            .BuildNotification();
        AppNotificationManager.Default.Show(notification);
    }

}