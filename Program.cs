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
Dictionary<string, IUser> teachersByCourse = new Dictionary<string, IUser>();

// Teachers
admin1.CreateAccount("linus.lindroth@nbi-handelsakademin.se");      // users[0]  Teacher  1joy.linus.lindroth
admin1.CreateAccount("manuel.noltorp@nbi-handelsakademin.se");      // users[1]  Teacher  1joy.manuel.noltorp
admin1.CreateAccount("max.ekstedt@nbi-handelsakademin.se");         // users[2]  Teacher  1joy.max.ekstedt
admin1.CreateAccount("sara.andersson@nbi-handelsakademin.se");      // users[3]  Teacher  1joy.sara.andersson
admin1.CreateAccount("johan.nilsson@nbi-handelsakademin.se");       // users[4]  Teacher  1joy.johan.nilsson
admin1.CreateAccount("anna.eriksson@nbi-handelsakademin.se");       // users[5]  Teacher  1joy.anna.eriksson
admin1.CreateAccount("mats.karlsson@nbi-handelsakademin.se");       // users[6]  Teacher  1joy.mats.karlsson
admin1.CreateAccount("eva.svensson@nbi-handelsakademin.se");        // users[7]  Teacher  1joy.eva.svensson
admin1.CreateAccount("per.johansson@nbi-handelsakademin.se");       // users[8]  Teacher  1joy.per.johansson
admin1.CreateAccount("lisa.persson@nbi-handelsakademin.se");        // users[9]  Teacher  1joy.lisa.persson
admin1.CreateAccount("anders.larsson@nbi-handelsakademin.se");      // users[10] Teacher  1joy.anders.larsson
admin1.CreateAccount("sofie.gustafsson@nbi-handelsakademin.se");    // users[11] Teacher  1joy.sofie.gustafsson

// Assign teachers to courses
teachersByCourse["Introduktion till mjukvaruutveckling"] = users[0];
teachersByCourse["Objekotorienterad programmering"]      = users[1];
teachersByCourse["Datadrivna applikationer"]             = users[2];
teachersByCourse["Databaser och informationsstrukturer"] = users[3];
teachersByCourse["Agil utvecklingskultur"]               = users[4];
teachersByCourse["Test, integration och leverans"]       = users[5];
teachersByCourse["Artificiell intelligens - teori och tillämpning, del 1"] = users[6];
teachersByCourse["Artificiell intelligens - teori och tillämpning, del 2"] = users[7];
teachersByCourse["Artificell intelligens - programmering python"]          = users[8];
teachersByCourse["Lärande i arbete (LIA 1)"] = users[9];
teachersByCourse["Lärande i arbete (LIA 2)"] = users[10];
teachersByCourse["Examensarbete"]            = users[11];

// Students
admin1.CreateAccount("max.vemic@student.nbi-handelsakademin.se");       //  users[12]  Student  1joy.max.vemic
admin1.CreateAccount("amir.hamza@student.nbi-handelsakademin.se");      //  users[13]  Student  1joy.amir.hamza
admin1.CreateAccount("emma.svensson@student.nbi-handelsakademin.se");   //  users[14]  Student  1joy.emma.svensson
admin1.CreateAccount("oliver.johansson@student.nbi-handelsakademin.se");//  users[15]  Student  1joy.oliver.johansson
admin1.CreateAccount("elvira.nilsson@student.nbi-handelsakademin.se");  //  users[16]  Student  1joy.elvira.nilsson
admin1.CreateAccount("lucas.persson@student.nbi-handelsakademin.se");   //  users[17]  Student  1joy.lucas.persson
admin1.CreateAccount("agnes.larsson@student.nbi-handelsakademin.se");   //  users[18]  Student  1joy.agnes.larsson
admin1.CreateAccount("isak.eriksson@student.nbi-handelsakademin.se");   //  users[19]  Student  1joy.isak.eriksson
admin1.CreateAccount("alva.karlsson@student.nbi-handelsakademin.se");   //  users[20]  Student  1joy.alva.karlsson
admin1.CreateAccount("leo.gustafsson@student.nbi-handelsakademin.se");  //  users[21]  Student  1joy.leo.gustafsson
admin1.CreateAccount("molly.olsson@student.nbi-handelsakademin.se");    //  users[22]  Student  1joy.molly.olsson
admin1.CreateAccount("vincent.axelsson@student.nbi-handelsakademin.se");//  users[23]  Student  1joy.vincent.axelsson
admin1.CreateAccount("wilma.sundberg@student.nbi-handelsakademin.se");  //  users[24]  Student  1joy.wilma.sundberg
admin1.CreateAccount("anton.lindberg@student.nbi-handelsakademin.se");  //  users[25]  Student  1joy.anton.lindberg
admin1.CreateAccount("julia.holm@student.nbi-handelsakademin.se");      //  users[26]  Student  1joy.julia.holm
admin1.CreateAccount("theo.bjork@student.nbi-handelsakademin.se");      //  users[27]  Student  1joy.theo.bjork

// Student course attendance
attendeesByCourse["Introduktion till mjukvaruutveckling"] = new List<IUser> { users[2], users[5], users[8], users[11], users[14] };
attendeesByCourse["Objekotorienterad programmering"]      = new List<IUser> { users[3], users[6], users[9], users[12], users[15] };
attendeesByCourse["Datadrivna applikationer"]             = new List<IUser> { users[4], users[7], users[10], users[13], users[16] };
attendeesByCourse["Databaser och informationsstrukturer"] = new List<IUser> { users[2], users[6], users[10], users[14] };
attendeesByCourse["Agil utvecklingskultur"]               = new List<IUser> { users[3], users[7], users[11], users[15] };
attendeesByCourse["Test, integration och leverans"]       = new List<IUser> { users[4], users[8], users[12], users[16] };
attendeesByCourse["Artificiell intelligens - teori och tillämpning, del 1"] = new List<IUser> { users[2], users[7], users[12], users[15] };
attendeesByCourse["Artificiell intelligens - teori och tillämpning, del 2"] = new List<IUser> { users[3], users[8], users[13], users[16] };
attendeesByCourse["Artificell intelligens - programmering python"]          = new List<IUser> { users[4], users[9], users[14] };
attendeesByCourse["Lärande i arbete (LIA 1)"] = new List<IUser> { users[2], users[5], users[10], users[13] };
attendeesByCourse["Lärande i arbete (LIA 2)"] = new List<IUser> { users[3], users[6], users[11], users[14] };
attendeesByCourse["Examensarbete"]            = new List<IUser> { users[4], users[7], users[9], users[12], users[15], users[16] };

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
                Console.Clear();
                Console.Write("Användarnamn: ");
                string? username = Console.ReadLine();
                Console.Clear();
                
                Console.Write("Lösenord: ");
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
                Console.Clear();
                foreach (User user in users)
                {
                    Console.WriteLine(user.Info());
                    Console.ReadLine();
                }
                break;
            case 3:     // Activate account
                Console.Clear();
                Console.WriteLine("För att kontot ska kunna aktiveras \nmåste skolan ha registrerat dig som\n användare. \n\nAnge din e-postadress nedan.");
                Console.Write("E-postadress: ");
                string? email = Console.ReadLine();
                admin1.ActivateAccount(email);
                break;
            case 4:     // Quit
                running = false;
                break;
            default:
                Console.Clear();
                Utility.Error("Något gick fel, har du valt ett av menyvalen?");
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
                    Utility.GenerateMenu(title: "Dina Kurser", choices: new[] { "" });
                    break;
                case 2: // Inkorg
                    Console.WriteLine("Inkorg");
                    // Write example messages here
                    Console.WriteLine("Exempelmeddelande 1\nExempelmeddelande 2\nExempelmeddelande 3");
                    break;
                case 3: // Min profil
                    Console.WriteLine(s.Info());
                    Console.ReadLine();
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