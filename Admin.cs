namespace App;

class Admin : IUser
{
    public string Username;
    string _password;
    SystemClass Sys;

    public Admin(SystemClass sys, string? username, string? password)
    {
        Sys = sys;
        Username = username;
        _password = password;
    }
    public void CreateAccount(string username, string password, string email, string name = "")
    {
        if (name != "")
        {
            Sys.Users.Add(new Student(name, username, password, email));
        }
        else
        {
            Sys.Users.Add(new Teacher(username, password, email));
        }
    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && password == _password;
    }
}