// Recreate learnpoint in the terminal

// Upload documents
// Create schedules with events
// Teachers can grade exams
// Students can upload files to exams
// Admins can create courses
// ...

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection.Metadata;
using App;

List<IUser> users = new List<IUser>();
IUser? active_user = null;
Admin admin1 = new Admin(users, "saer001", "admin");

Dictionary<string, List<IUser>> attendeesByCourse = new Dictionary<string, List<IUser>>();

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
        Utility.GenerateMenu(title: " ", choices: new[] { "Logga in", "Glömt lösenord eller användarnamn?",
                                                          "Aktivera konto", "Avsluta" });
        int.TryParse(Console.ReadLine(), out int input);
        switch (input)
        {
            case 1:   // Log in
                Console.Write("Username: ");
                string? username = Console.ReadLine();
                Console.Clear();
                
                Console.Write("Password: ");
                string? password = Console.ReadLine();
                Console.Clear();
                foreach (IUser user in users)
                {
                    if (user.TryLogin(username, password))
                    {
                        active_user = user;
                        break;
                    }
                }
                break;
            case 2:     // Forgot password
                foreach (User user in users)
                {
                    Console.WriteLine(user.Info());
                    Console.ReadLine();
                }
                break;
            case 3:     // Activate account
                Console.WriteLine("För att kontot ska kunna aktiveras \nmåste skolan ha registrerat dig som\n användare. \n\nAnge din e-postadress nedan.");
                Console.Write("E-postadress: ");
                string? email = Console.ReadLine();
                admin1.ActivateAccount(email);
                break;
            case 4:     // Quit
                running = false;
                break;
            default:
                Utility.Error("Något gick fel");
                break;
        }
    }
    else
    {
        if (active_user is Teacher t)
        {
            Utility.GenerateMenu(title: $"{t.Name} välkommen till Learnpoint");
        }
        if (active_user is Student s)
        {
            Utility.GenerateMenu(title: $"{s.Name} välkommen till Learnpoint", choices: new[] { "Kurser", "Inkorg", "Min profil", "Logga ut" });
            int.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1: // kurser
                    Utility.GenerateMenu(title: "Kurser", choices: new[] { "" });
                    break;
                case 2: // Inkorg
                    break;
                case 3: // Min profil
                    break;
                case 4: // Logga ut
                    active_user = null;
                    break;
                default:
                    Utility.Error("Something went wrong");
                    break;
            }
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