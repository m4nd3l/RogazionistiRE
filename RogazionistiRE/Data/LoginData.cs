using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
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
    
    #region Login
    public async Task<LoginResult> loginIntoMastercom() {
        //TODO : complete
    }
    #endregion
    
    #region Credential Saving System
    public void saveData() {
        var vault = new PasswordVault();

        // Removes old credentials
        try { vault.Remove(new PasswordCredential(FileWriter.ApplicationName, _username, _password)); } 
        catch (Exception exception) { Debug.Write($"Raised an exception while saving the login data.\nMore info:\n{exception}"); }

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
            Debug.Write($"Raised an exception while retrieving the login data.\nMore info:\n{exception}");
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
    
    public void deleteData() {
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