namespace App;

class Teacher : User, IUser
{
    public Teacher(string username, string password, string email)
    : base (username, password, email)
    {

    }
    public bool TryLogin(string username, string password)
    {
        return username == username && _password == password;
    }
}