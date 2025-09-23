using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace App;

abstract class User
{
    public string Name;
    public string Username;
    protected string _password;
    public string Email;
    public User(string name, string username, string email)
    {
        Name = name;
        Username = username;
        Email = email;
    }
    public virtual string Info()
    {
        string txt = "";
        txt += $"\nNamn:         {Name}\n" +
                 $"Användarnamn: {Username}\n" +
                 $"Email:        {Email}";
        return txt;
    }
    public void SetPassword(string password)
    {
        _password = password;
        Utility.Success("Password Creation Success!");
    }
}