namespace App;

class Teacher : User, IUser
{
    public Teacher(string? Username, string? password, string? email)
    : base (Username, password, email)
    {

    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && _password == password;
    }
}