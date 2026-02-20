using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        var vault = new PasswordVault();

        // Removes old credentials
        try { vault.Remove(new PasswordCredential(FileWriter.ApplicationName, _username, _password)); } 
        catch (Exception exception) { Debug.WriteLine($"Raised an exception while saving the login data.\nMore info:\n{exception}"); }

        // Saves new credentials
        vault.Add(new PasswordCredential(FileWriter.ApplicationName, _username, _password));
        // Sets the value for "isLoggedIn" saved in disk variable to true
        FileWriter.aSave("isLoggedIn", "true");
    }
    
    public static LoginData? getCredentialFromLocker() {
        var vault = new PasswordVault();

        IReadOnlyList<PasswordCredential> credentialList;

        // Tries to get the login data
        try { credentialList = vault.FindAllByResource(FileWriter.ApplicationName); } 
        catch (Exception exception) {
            Debug.WriteLine($"Raised an exception while retrieving the login data.\nMore info:\n{exception}");
            FileWriter.aSave("isLoggedIn", "false");
            return null;
        }

        // Retrieves the data
        credentialList[0].RetrievePassword();

        // Gets the username and password
        string username = credentialList[0].UserName;
        string password = credentialList[0].Password;

        return new LoginData(username, password);
    }
    
    public static void deleteData() {
        FileWriter.aSave("isLoggedIn", "false");
    }
    
    public static bool credentialsInTheLocker() {
        var vault = new PasswordVault();

        try {
            var credentialList = vault.FindAllByResource(FileWriter.ApplicationName);
            return credentialList.Count > 0;
        } catch { return false; }
    }
    #endregion

    public override string ToString() {
        return $"Username: {_username}, Password: {_password}";
    }

}