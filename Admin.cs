using System.ComponentModel;
using System.Globalization;

namespace App;

class Admin : IUser
{
    public string Username;
    string _password;
    List<IUser> Sys;

    public Admin(List<IUser> sys, string username, string password)
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
                Sys.Add(new Teacher(name, username, email));
            }
            else
            {
                Sys.Add(new Student(name, username, email));
            }
        }
        catch
        {
            Utility.Error("Error when creating account");
        }
    }
    public void ActivateAccount(string email)
    {
        string TryPassword()
        {
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Confirm Password:");
            string passwordConfirm = Console.ReadLine();
            if (password != passwordConfirm)
            {
                Console.WriteLine("Password");
                return TryPassword();
            }
            return password;
        }
        foreach (User user in Sys)
        {
            if (email == user.Email)
            {
                Console.WriteLine("Create a password for your account");
                string password = TryPassword();
                user.SetPassword(password);
                break;
            }
        }
    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && password == _password;
    }
}