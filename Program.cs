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

SystemClass system = new SystemClass();
IUser? active_user = null;
Admin admin1 = new Admin(system, "saer001", "admin");

Dictionary<string, List<IUser>> attendeesByCourse = new Dictionary<string, List<IUser>>();

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


system.attendeesByCourse.Add("Introduktion till mjukvaruutveckling", new List<User>());
system.attendeesByCourse.Add("Objekotorienterad programmering", new List<User>());
system.attendeesByCourse.Add("Datadrivna applikationer", new List<User>());
system.attendeesByCourse.Add("Databaser och informationsstrukturer", new List<User>());
system.attendeesByCourse.Add("Agil utvecklingskultur", new List<User>());
system.attendeesByCourse.Add("Test, integration och leverans", new List<User>());
system.attendeesByCourse.Add("Artificiell intelligens - programmering python", new List<User>());
system.attendeesByCourse.Add("Artificiell intelligens - teori och tillämpning, del 1", new List<User>());
system.attendeesByCourse.Add("Artificiell intelligens - teori och tillämpning, del 2", new List<User>());
system.attendeesByCourse.Add("Lärande i arbete (LIA 1)", new List<User>());
system.attendeesByCourse.Add("Lärande i arbete (LIA 2)", new List<User>());
system.attendeesByCourse.Add("Examensarbete", new List<User>());


// Introduktion till mjukvaruutveckling
admin1.CourseRegister("Introduktion till mjukvaruutveckling", system.users[0]);
admin1.CourseRegister("Introduktion till mjukvaruutveckling", system.users[3]);
admin1.CourseRegister("Introduktion till mjukvaruutveckling", system.users[12]);
admin1.CourseRegister("Introduktion till mjukvaruutveckling", system.users[14]);
admin1.CourseRegister("Introduktion till mjukvaruutveckling", system.users[16]);
admin1.CourseRegister("Introduktion till mjukvaruutveckling", system.users[18]);
admin1.CourseRegister("Introduktion till mjukvaruutveckling", system.users[21]);

// Objekotorienterad programmering
admin1.CourseRegister("Objekotorienterad programmering", system.users[1]);
admin1.CourseRegister("Objekotorienterad programmering", system.users[4]);
admin1.CourseRegister("Objekotorienterad programmering", system.users[13]);
admin1.CourseRegister("Objekotorienterad programmering", system.users[15]);
admin1.CourseRegister("Objekotorienterad programmering", system.users[19]);
admin1.CourseRegister("Objekotorienterad programmering", system.users[22]);
admin1.CourseRegister("Objekotorienterad programmering", system.users[25]);

// Datadrivna applikationer
admin1.CourseRegister("Datadrivna applikationer", system.users[2]);
admin1.CourseRegister("Datadrivna applikationer", system.users[7]);
admin1.CourseRegister("Datadrivna applikationer", system.users[12]);
admin1.CourseRegister("Datadrivna applikationer", system.users[17]);
admin1.CourseRegister("Datadrivna applikationer", system.users[20]);
admin1.CourseRegister("Datadrivna applikationer", system.users[23]);
admin1.CourseRegister("Datadrivna applikationer", system.users[26]);

// Databaser och informationsstrukturer
admin1.CourseRegister("Databaser och informationsstrukturer", system.users[5]);
admin1.CourseRegister("Databaser och informationsstrukturer", system.users[9]);
admin1.CourseRegister("Databaser och informationsstrukturer", system.users[13]);
admin1.CourseRegister("Databaser och informationsstrukturer", system.users[16]);
admin1.CourseRegister("Databaser och informationsstrukturer", system.users[19]);
admin1.CourseRegister("Databaser och informationsstrukturer", system.users[24]);
admin1.CourseRegister("Databaser och informationsstrukturer", system.users[27]);

// Agil utvecklingskultur
admin1.CourseRegister("Agil utvecklingskultur", system.users[6]);
admin1.CourseRegister("Agil utvecklingskultur", system.users[10]);
admin1.CourseRegister("Agil utvecklingskultur", system.users[12]);
admin1.CourseRegister("Agil utvecklingskultur", system.users[14]);
admin1.CourseRegister("Agil utvecklingskultur", system.users[18]);
admin1.CourseRegister("Agil utvecklingskultur", system.users[22]);
admin1.CourseRegister("Agil utvecklingskultur", system.users[25]);

// Test, integration och leverans
admin1.CourseRegister("Test, integration och leverans", system.users[8]);
admin1.CourseRegister("Test, integration och leverans", system.users[11]);
admin1.CourseRegister("Test, integration och leverans", system.users[15]);
admin1.CourseRegister("Test, integration och leverans", system.users[17]);
admin1.CourseRegister("Test, integration och leverans", system.users[20]);
admin1.CourseRegister("Test, integration och leverans", system.users[23]);
admin1.CourseRegister("Test, integration och leverans", system.users[26]);

// Artificiell intelligens - teori och tillämpning, del 1
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", system.users[0]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", system.users[7]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", system.users[13]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", system.users[18]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", system.users[21]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", system.users[24]);

// Artificiell intelligens - teori och tillämpning, del 2
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", system.users[1]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", system.users[6]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", system.users[14]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", system.users[19]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", system.users[22]);
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", system.users[27]);

// Artificiell intelligens - programmering python
admin1.CourseRegister("Artificiell intelligens - programmering python", system.users[2]);
admin1.CourseRegister("Artificiell intelligens - programmering python", system.users[9]);
admin1.CourseRegister("Artificiell intelligens - programmering python", system.users[15]);
admin1.CourseRegister("Artificiell intelligens - programmering python", system.users[20]);
admin1.CourseRegister("Artificiell intelligens - programmering python", system.users[23]);
admin1.CourseRegister("Artificiell intelligens - programmering python", system.users[25]);

// Lärande i arbete (LIA 1)
admin1.CourseRegister("Lärande i arbete (LIA 1)", system.users[3]);
admin1.CourseRegister("Lärande i arbete (LIA 1)", system.users[8]);
admin1.CourseRegister("Lärande i arbete (LIA 1)", system.users[12]);
admin1.CourseRegister("Lärande i arbete (LIA 1)", system.users[16]);
admin1.CourseRegister("Lärande i arbete (LIA 1)", system.users[21]);
admin1.CourseRegister("Lärande i arbete (LIA 1)", system.users[26]);

// Lärande i arbete (LIA 2)
admin1.CourseRegister("Lärande i arbete (LIA 2)", system.users[4]);
admin1.CourseRegister("Lärande i arbete (LIA 2)", system.users[10]);
admin1.CourseRegister("Lärande i arbete (LIA 2)", system.users[13]);
admin1.CourseRegister("Lärande i arbete (LIA 2)", system.users[17]);
admin1.CourseRegister("Lärande i arbete (LIA 2)", system.users[22]);
admin1.CourseRegister("Lärande i arbete (LIA 2)", system.users[27]);

// Examensarbete
admin1.CourseRegister("Examensarbete", system.users[5]);
admin1.CourseRegister("Examensarbete", system.users[11]);
admin1.CourseRegister("Examensarbete", system.users[14]);
admin1.CourseRegister("Examensarbete", system.users[18]);
admin1.CourseRegister("Examensarbete", system.users[20]);
admin1.CourseRegister("Examensarbete", system.users[24]);
admin1.CourseRegister("Examensarbete", system.users[25]);

// attendeesByCourse["Introduktion till mjukvaruutveckling"] = new List<IUser> { users[0], users[3], users[12], users[14], users[16], users[18], users[21] };
// attendeesByCourse["Objekotorienterad programmering"]      = new List<IUser> { users[1], users[4], users[13], users[15], users[19], users[22], users[25] };
// attendeesByCourse["Datadrivna applikationer"]             = new List<IUser> { users[2], users[7], users[12], users[17], users[20], users[23], users[26] };
// attendeesByCourse["Databaser och informationsstrukturer"] = new List<IUser> { users[5], users[9], users[13], users[16], users[19], users[24], users[27] };
// attendeesByCourse["Agil utvecklingskultur"]               = new List<IUser> { users[6], users[10], users[12], users[14], users[18], users[22], users[25] };
// attendeesByCourse["Test, integration och leverans"]       = new List<IUser> { users[8], users[11], users[15], users[17], users[20], users[23], users[26] };
// attendeesByCourse["Artificiell intelligens - teori och tillämpning, del 1"] = new List<IUser> { users[0], users[7], users[13], users[18], users[21], users[24] };
// attendeesByCourse["Artificiell intelligens - teori och tillämpning, del 2"] = new List<IUser> { users[1], users[6], users[14], users[19], users[22], users[27] };
// attendeesByCourse["Artificell intelligens - programmering python"]          = new List<IUser> { users[2], users[9], users[15], users[20], users[23], users[25] };
// attendeesByCourse["Lärande i arbete (LIA 1)"] = new List<IUser> { users[3], users[8], users[12], users[16], users[21], users[26] };
// attendeesByCourse["Lärande i arbete (LIA 2)"] = new List<IUser> { users[4], users[10], users[13], users[17], users[22], users[27] };
// attendeesByCourse["Examensarbete"]            = new List<IUser> { users[5], users[11], users[14], users[18], users[20], users[24], users[25] };

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
                foreach (IUser user in system.users)
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
                foreach (User user in system.users)
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
            Utility.GenerateMenu(title: $"{t.Name} välkommen till Learnpoint", choices: new[] { "Kurser", "Inkorg", "Min profil", "Logga ut" });
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
                    Console.WriteLine(t.Info());
                    Console.ReadLine();
                    break;
                case 4: // Logga ut
                    active_user = null;
                    break;
                default:
                    Console.Clear();
                    Utility.Error("Något gick fel, har du valt ett av menyvalen?");
                    break;
            }
        }
        if (active_user is Student s)
        {
            Utility.GenerateMenu(title: $"{s.Name} välkommen till Learnpoint", choices: new[] { "Kurser", "Inkorg", "Min profil", "Logga ut" });
            int.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1: // kurser
                    Console.Clear();
                    List<string> courseList = system.CheckCourses(s);
                    Console.ReadLine();
                    break;
                case 2: // Inkorg
                    Console.Clear();
                    Console.WriteLine("Inkorg");
                    Console.WriteLine("Exempelmeddelande 1\nExempelmeddelande 2\nExempelmeddelande 3");
                    Console.ReadLine();
                    break;
                case 3: // Min profil
                    Console.Clear();
                    Console.WriteLine(s.Info());
                    Console.ReadLine();
                    break;
                case 4: // Logga ut
                    active_user = null;
                    Utility.Success("Loggar ut...");
                    break;
                default:
                Console.Clear();
                Utility.Error("Något gick fel, har du valt ett av menyvalen?");
                break;
            }
        }
    }
}