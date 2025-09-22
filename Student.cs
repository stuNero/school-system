namespace App;

class Student : User, IUser
{
    public string Name;
    public Student(string name, string username,string password, string email)
    : base(username, password, email)
    {
        Name = name;
    }
    public bool TryLogin(string username, string password)
    {
        return username == Email && password == _password;
    }
}