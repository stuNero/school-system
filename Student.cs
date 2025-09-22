namespace App;

class Student : User, IUser
{
    public string? Name;
    public Student(string? name, string? Username,string? password, string email)
    : base(Username, password, email)
    {
        Name = name;
    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && password == _password;
    }
}