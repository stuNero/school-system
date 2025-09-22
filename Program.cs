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

using System.Reflection.Metadata;
using App;
SystemClass system = new SystemClass();
IUser? active_user = null;
Admin admin1 = new Admin(system, "saer001", "admin");

admin1.CreateAccount("manuel.noltorp@nbi-handelsakademin.se");
admin1.CreateAccount("max.ekstedt@nbi-handelsakademin.se");
admin1.CreateAccount("max.vemic@student.nbi-handelsakademin.se");
admin1.CreateAccount("amir.hamza@student.nbi-handelsakademin.se");

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
                foreach (User user in system.Users)
                {
                    Console.WriteLine(user.Info());
                    Console.ReadLine();
                }
                break;
            case 3:
                Console.WriteLine("För att kontot ska kunna aktiveras \nmåste skolan ha registrerat dig som\n användare. \n\nAnge din e-postadress nedan.");
                Console.Write("E-postadress: ");
                string? email = Console.ReadLine();
                break;
            case 4:
                running = false;
                break;
            default:
                Utility.Error("Något gick fel");
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