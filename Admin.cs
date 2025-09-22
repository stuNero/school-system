namespace App;

class Admin : IUser
{
    public string Username;
    string _password;

    public Admin(string username, string password)
    {
        Username = username;
        _password = password;
    }
    public User CreateAccount(string username, string password, string email, string name = "")
    {
        if (name != "")
        {
            return new Student(name, username, password, email);
        }
        else
        {
            return new Teacher(username, password, email);
        }
    }
    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }
}