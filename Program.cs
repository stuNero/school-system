// Recreate learnpoint in the terminal

// Logga in, logga ut
// Students, Teachers, Admin
// Admin can create new accounts
// Upload documents
// Create schedules with events
// Teachers can grade exams
// Students can upload files to exams
// Admins can create courses
// ...

using App;

List<IUser> users = new List<IUser>();
users.Add(new Student("max", "mave002", "pass", "max.vemic@hotmail.com"));
users.Add(new Teacher("manuel", "pass", "manuel.nortorp@hotmai.com"));
users.Add(new Admin("saer001", "sara.eriksson@hotmail.com"));
IUser? active_user = null;

bool running = true;

while (running)
{
    Console.Clear();
    if (active_user == null)
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Clear();

        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Clear();

        foreach (IUser user in users)
        {
            if (user.TryLogin(username, password))
            {
                active_user = user;
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("School system");

        if (active_user is Teacher t)
        {
            Console.WriteLine("Welcome Teacher " + t.Username);
        }
        if (active_user is Student s)
        {
            Console.WriteLine("Welcome Student " + s.Name);
        }
        Console.WriteLine("logout");
        switch (Console.ReadLine())
        {
            case "logout":
                active_user = null;
                break;
        }
    }
}