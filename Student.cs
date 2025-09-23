namespace App;

class Student : User, IUser
{

    public Student(string name, string username, string email)
    : base(name, username, email)
    {
        Name = name;
        Username = username;
        Email = email;
    }
    public bool TryLogin(string? username, string? password)
    {
        return Username == username && password == _password;
    }
    public void GenerateMenu()
    {
        Utility.GenerateMenu(title: "Välkommen till Learnpoint", choices: new[]{"Se kurser","Min inkorg","Min profil","Logga ut"});
    }
}