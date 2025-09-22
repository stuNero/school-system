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
SystemClass system = new SystemClass();
IUser? active_user = null;
Admin admin1 = new Admin(system, "saer001", "admin");
bool running = true;

while (running)
{
    Console.Clear();
    if (active_user == null)
    {
        Utility.GenerateMenu(title: " ", choices: new[] { "Logga in", "Glömt lösenord eller användarnamn?", "Aktivera konto", "Avsluta" });

        int.TryParse(Console.ReadLine(), out int input);
        switch (input)
        {
            case 1:
                Console.Write("Username: ");
                string? username = Console.ReadLine();
                Console.Clear();
                
                Console.Write("Password: ");
                string? password = Console.ReadLine();
                Console.Clear();
                foreach (IUser user in system.Users)
                {
                    if (user.TryLogin(username, password))
                    {
                        active_user = user;
                        break;
                    }
                }
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                running = false;
                break;
            default:
                break;
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