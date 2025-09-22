using System.Globalization;

namespace App;

class Admin : IUser
{
    public string Username;
    string _password;
    SystemClass Sys;

    public Admin(SystemClass sys, string username, string password)
    {
        Sys = sys;
        Username = username;
        _password = password;
    }
    public void CreateAccount(string email)
    {
        try
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string[] emailSplit = email.Split("@");
            string[] nameSplit = emailSplit[0].Split(".");
            string username = $"1joy.{nameSplit[0]}.{nameSplit[1]}";
            string name = textInfo.ToTitleCase($"{nameSplit[0]} {nameSplit[1]}");
            if (emailSplit[1].ToLower() != "student.nbi-handelsakademin.se")
            {
                Sys.Users.Add(new Teacher(name, username, email));
            }
            else
            {
                Sys.Users.Add(new Student(name, username, email));
            }
        }
        catch
        {
            Utility.Error("Error when creating account");
        }
    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && password == _password;
    }
}