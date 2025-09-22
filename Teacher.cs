namespace App;

class Teacher : User, IUser
{
    public Teacher(string name, string username, string email)
    : base(name, username, email)
    {
        Name = name;
        Username = username;
        Email = email;
    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && _password == password;
    }
}