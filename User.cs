namespace App;

class User
{
    public string Username;
    protected string _password;
    public string Email;

    public User(string username, string password, string email)
    {
        Username = username;
        _password = password;
        Email = email;
    }
}