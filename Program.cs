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

// Courses 
admin1.CreateCourse("Introduktion till mjukvaruutveckling"); // courses[0]
admin1.CreateCourse("Objekotorienterad programmering"); // courses[1]
admin1.CreateCourse("Datadrivna applikationer"); // courses[2]
admin1.CreateCourse("Databaser och informationsstrukturer"); // courses[3]
admin1.CreateCourse("Agil utvecklingskultur"); // courses[4]
admin1.CreateCourse("Test, integration och leverans"); // courses[5]
admin1.CreateCourse("Artificiell intelligens - programmering python"); // courses[6]
admin1.CreateCourse("Artificiell intelligens - teori och tillämpning, del 1"); // courses[7]
admin1.CreateCourse("Artificiell intelligens - teori och tillämpning, del 2"); // courses[8]
admin1.CreateCourse("Lärande i arbete (LIA 1)"); // courses[9]
admin1.CreateCourse("Lärande i arbete (LIA 2)");
admin1.CreateCourse("Examensarbete");

// Teachers 
admin1.CreateAccount("linus.lindroth@nbi-handelsakademin.se"); // users[0]  // Teacher 1joy.linus.lindroth 
admin1.CreateAccount("manuel.noltorp@nbi-handelsakademin.se"); // users[1] Teacher 1joy.manuel.noltorp 
admin1.CreateAccount("max.ekstedt@nbi-handelsakademin.se"); // users[2] Teacher 1joy.max.ekstedt 
admin1.CreateAccount("sara.andersson@nbi-handelsakademin.se"); // users[3] Teacher 1joy.sara.andersson 
admin1.CreateAccount("johan.nilsson@nbi-handelsakademin.se"); // users[4] Teacher 1joy.johan.nilsson 
admin1.CreateAccount("anna.eriksson@nbi-handelsakademin.se"); // users[5] Teacher 1joy.anna.eriksson 
admin1.CreateAccount("mats.karlsson@nbi-handelsakademin.se"); // users[6] Teacher 1joy.mats.karlsson 
admin1.CreateAccount("eva.svensson@nbi-handelsakademin.se"); // users[7] Teacher 1joy.eva.svensson 
admin1.CreateAccount("per.johansson@nbi-handelsakademin.se"); // users[8] Teacher 1joy.per.johansson 
admin1.CreateAccount("lisa.persson@nbi-handelsakademin.se"); // users[9] Teacher 1joy.lisa.persson 

// Students 
admin1.CreateAccount("max.vemic@student.nbi-handelsakademin.se"); // users[12] Student 1joy.max.vemic 
admin1.CreateAccount("amir.hamza@student.nbi-handelsakademin.se"); // users[13] Student 1joy.amir.hamza 
admin1.CreateAccount("emma.svensson@student.nbi-handelsakademin.se"); // users[14] Student 1joy.emma.svensson 
admin1.CreateAccount("oliver.johansson@student.nbi-handelsakademin.se");// users[15] Student 1joy.oliver.johansson 
admin1.CreateAccount("elvira.nilsson@student.nbi-handelsakademin.se"); // users[16] Student 1joy.elvira.nilsson 
admin1.CreateAccount("lucas.persson@student.nbi-handelsakademin.se"); // users[17] Student 1joy.lucas.persson 
admin1.CreateAccount("agnes.larsson@student.nbi-handelsakademin.se"); // users[18] Student 1joy.agnes.larsson 
admin1.CreateAccount("isak.eriksson@student.nbi-handelsakademin.se"); // users[19] Student 1joy.isak.eriksson 
admin1.CreateAccount("alva.karlsson@student.nbi-handelsakademin.se"); // users[20] Student 1joy.alva.karlsson 
admin1.CreateAccount("leo.gustafsson@student.nbi-handelsakademin.se"); // users[21] Student 1joy.leo.gustafsson 
admin1.CreateAccount("molly.olsson@student.nbi-handelsakademin.se"); // users[22] Student 1joy.molly.olsson 
admin1.CreateAccount("vincent.axelsson@student.nbi-handelsakademin.se");// users[23] Student 1joy.vincent.axelsson 
admin1.CreateAccount("wilma.sundberg@student.nbi-handelsakademin.se"); // users[24] Student 1joy.wilma.sundberg 
admin1.CreateAccount("anton.lindberg@student.nbi-handelsakademin.se"); // users[25] Student 1joy.anton.lindberg 
admin1.CreateAccount("julia.holm@student.nbi-handelsakademin.se"); // users[26] Student 1joy.julia.holm 
admin1.CreateAccount("theo.bjork@student.nbi-handelsakademin.se"); // users[27] Student 1joy.theo.bjork

// Teachers
admin1.CourseRegister("Introduktion till mjukvaruutveckling", "1joy.linus.lindroth");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.manuel.noltorp");
admin1.CourseRegister("Datadrivna applikationer", "1joy.manuel.noltorp");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.max.ekstedt");
admin1.CourseRegister("Datadrivna applikationer", "1joy.max.ekstedt");
admin1.CourseRegister("Databaser och informationsstrukturer", "1joy.sara.andersson");
admin1.CourseRegister("Agil utvecklingskultur", "1joy.johan.nilsson");
admin1.CourseRegister("Test, integration och leverans", "1joy.anna.eriksson");
admin1.CourseRegister("Artificiell intelligens - programmering python", "1joy.mats.karlsson");
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", "1joy.eva.svensson");
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", "1joy.per.johansson");
admin1.CourseRegister("Lärande i arbete (LIA 1)", "1joy.lisa.persson");
admin1.CourseRegister("Lärande i arbete (LIA 2)", "1joy.lisa.persson");
admin1.CourseRegister("Examensarbete", "1joy.lisa.persson");

// Students (4 courses each, distributed)
admin1.CourseRegister("Introduktion till mjukvaruutveckling", "1joy.max.vemic");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.max.vemic");
admin1.CourseRegister("Datadrivna applikationer", "1joy.max.vemic");
admin1.CourseRegister("Databaser och informationsstrukturer", "1joy.max.vemic");

admin1.CourseRegister("Agil utvecklingskultur", "1joy.amir.hamza");
admin1.CourseRegister("Test, integration och leverans", "1joy.amir.hamza");
admin1.CourseRegister("Artificiell intelligens - programmering python", "1joy.amir.hamza");
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", "1joy.amir.hamza");

admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", "1joy.emma.svensson");
admin1.CourseRegister("Lärande i arbete (LIA 1)", "1joy.emma.svensson");
admin1.CourseRegister("Lärande i arbete (LIA 2)", "1joy.emma.svensson");
admin1.CourseRegister("Examensarbete", "1joy.emma.svensson");

admin1.CourseRegister("Introduktion till mjukvaruutveckling", "1joy.oliver.johansson");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.oliver.johansson");
admin1.CourseRegister("Datadrivna applikationer", "1joy.oliver.johansson");
admin1.CourseRegister("Databaser och informationsstrukturer", "1joy.oliver.johansson");

admin1.CourseRegister("Agil utvecklingskultur", "1joy.elvira.nilsson");
admin1.CourseRegister("Test, integration och leverans", "1joy.elvira.nilsson");
admin1.CourseRegister("Artificiell intelligens - programmering python", "1joy.elvira.nilsson");
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", "1joy.elvira.nilsson");

admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", "1joy.lucas.persson");
admin1.CourseRegister("Lärande i arbete (LIA 1)", "1joy.lucas.persson");
admin1.CourseRegister("Lärande i arbete (LIA 2)", "1joy.lucas.persson");
admin1.CourseRegister("Examensarbete", "1joy.lucas.persson");

admin1.CourseRegister("Introduktion till mjukvaruutveckling", "1joy.agnes.larsson");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.agnes.larsson");
admin1.CourseRegister("Datadrivna applikationer", "1joy.agnes.larsson");
admin1.CourseRegister("Databaser och informationsstrukturer", "1joy.agnes.larsson");

admin1.CourseRegister("Agil utvecklingskultur", "1joy.isak.eriksson");
admin1.CourseRegister("Test, integration och leverans", "1joy.isak.eriksson");
admin1.CourseRegister("Artificiell intelligens - programmering python", "1joy.isak.eriksson");
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", "1joy.isak.eriksson");

admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", "1joy.alva.karlsson");
admin1.CourseRegister("Lärande i arbete (LIA 1)", "1joy.alva.karlsson");
admin1.CourseRegister("Lärande i arbete (LIA 2)", "1joy.alva.karlsson");
admin1.CourseRegister("Examensarbete", "1joy.alva.karlsson");

admin1.CourseRegister("Introduktion till mjukvaruutveckling", "1joy.leo.gustafsson");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.leo.gustafsson");
admin1.CourseRegister("Datadrivna applikationer", "1joy.leo.gustafsson");
admin1.CourseRegister("Databaser och informationsstrukturer", "1joy.leo.gustafsson");

admin1.CourseRegister("Agil utvecklingskultur", "1joy.molly.olsson");
admin1.CourseRegister("Test, integration och leverans", "1joy.molly.olsson");
admin1.CourseRegister("Artificiell intelligens - programmering python", "1joy.molly.olsson");
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", "1joy.molly.olsson");

admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", "1joy.vincent.axelsson");
admin1.CourseRegister("Lärande i arbete (LIA 1)", "1joy.vincent.axelsson");
admin1.CourseRegister("Lärande i arbete (LIA 2)", "1joy.vincent.axelsson");
admin1.CourseRegister("Examensarbete", "1joy.vincent.axelsson");

admin1.CourseRegister("Introduktion till mjukvaruutveckling", "1joy.wilma.sundberg");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.wilma.sundberg");
admin1.CourseRegister("Datadrivna applikationer", "1joy.wilma.sundberg");
admin1.CourseRegister("Databaser och informationsstrukturer", "1joy.wilma.sundberg");

admin1.CourseRegister("Agil utvecklingskultur", "1joy.anton.lindberg");
admin1.CourseRegister("Test, integration och leverans", "1joy.anton.lindberg");
admin1.CourseRegister("Artificiell intelligens - programmering python", "1joy.anton.lindberg");
admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 1", "1joy.anton.lindberg");

admin1.CourseRegister("Artificiell intelligens - teori och tillämpning, del 2", "1joy.julia.holm");
admin1.CourseRegister("Lärande i arbete (LIA 1)", "1joy.julia.holm");
admin1.CourseRegister("Lärande i arbete (LIA 2)", "1joy.julia.holm");
admin1.CourseRegister("Examensarbete", "1joy.julia.holm");

admin1.CourseRegister("Introduktion till mjukvaruutveckling", "1joy.theo.bjork");
admin1.CourseRegister("Objekotorienterad programmering", "1joy.theo.bjork");
admin1.CourseRegister("Datadrivna applikationer", "1joy.theo.bjork");
admin1.CourseRegister("Databaser och informationsstrukturer", "1joy.theo.bjork");

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
                    List<Course> coursesByUser = system.GatherCourses(s);
                    List<string> courseNames = new List<string>();
                    foreach (Course course in coursesByUser)
                    {
                        courseNames.Add(course.Name);
                    }
                    Utility.GenerateMenu(title: "[Kurser]", choices: courseNames.ToArray());
                    Console.ReadLine();
                    break;
                case 2: // Inkorg
                    Console.Clear();
                    Console.WriteLine("[Inkorg]");
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