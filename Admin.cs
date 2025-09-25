using System.ComponentModel;
using System.Globalization;
using System.Diagnostics;
using System.Reflection.Metadata;
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
                Sys.users.Add(new Teacher(name, username, email));
            }
            else
            {
                Sys.users.Add(new Student(name, username, email));
            }
        }
        catch
        {
            Utility.Error("Error when creating account");
        }
    }
    public void ActivateAccount(string email)
    {
        bool check = false;
        foreach (User user in Sys.users)
        {
            if (user.Email == email)
            {
                check = true;
            }
        }
        if (!check)
        {
            Utility.Error($"Email: -{email}- fanns inte i systemet\nKontakta admin för support...");
            return;
        }
        string TryPassword()
        {
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();
            Console.Write("Bekräfta lösenord:");
            string passwordConfirm = Console.ReadLine();
            if (password != passwordConfirm)
            {
                Utility.Error("Lösenorden är inte likadana\nProva igen...");
                return TryPassword();
            }
            return password;
        }
        foreach (User user in Sys.users)
        {
            if (email == user.Email)
            {

                Console.WriteLine("Skapa ett lösenord för ditt konto.");
                string password = TryPassword();
                user.SetPassword(password);
                Utility.Success($"Aktivering av ditt konto lyckades!\n"
                            + "Dina kontouppgifter:"
                            + $"\n{user.Info(inclPassword: true)}");
                break;
            }
        }
    }
    public void CourseRegister(string courseName, string username)
    {
        foreach (Course course in Sys.courses)
        {
            if (courseName.ToLower() == course.Name.ToLower())
            {
                foreach (User user in Sys.users)
                {
                    if (username.ToLower() == user.Username.ToLower())
                    {
                        if (course.students.Contains(user) || course.teachers.Contains(user))
                        {
                            Utility.Error($"Användare '{user.Username}' redan registrerad på kursen");
                            return;    
                        }
                        if (user is Teacher t)
                        {
                            course.teachers.Add(t);
                        }
                        else if (user is Student s)
                        {
                            course.students.Add(s);
                        }
                    }
                }
            }
        }
    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && password == _password;
    }
    public void CreateCourse(string name)
    {
        foreach (Course course in Sys.courses)
        {
            if (course.Name.ToLower() == name.ToLower())
            {
                Utility.Error($"Kursen '{name}' finns redan");
                return;
            }
        }
        Sys.courses.Add(new Course(name));
    }
}