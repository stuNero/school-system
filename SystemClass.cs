namespace App;

class SystemClass
{
    public List<User> users = new List<User>();
    public List<Course> courses = new List<Course>();

    // Directories to saved data
    string SavedUsersDir = "saved_users.md";
    string SavedCoursesDir = "saved_users.md";

    public SystemClass()
    {
        // List<string> usersFromFile = ImportUserProfile(SavedUsersDir);
    }
    public List<Course> GatherCourses(User user)
    {
        List<Course> coursesByUser = new List<Course>();
        foreach (Course course in courses)
        {
            if (course.students.Contains(user) || course.teachers.Contains(user))
            {
                coursesByUser.Add(course);
            }
        }
        if (coursesByUser.Count == 0)
        {
            Utility.Error("Du är inte registrerad på några kurser");
            return coursesByUser;
        }
        else
        {
            return coursesByUser;
        }
    }
    // public static List<string> ImportUserProfile(string fileName)
    // {
    //     List<string> fileContent = new List<string>();
    //     using (StreamReader reader = new StreamReader(fileName))
    //     {
    //         string line;
    //         string start = "--new_user--";
    //         string end = "--end_user--";
    //         bool insideBlock = false;
    //         while ((line = reader.ReadLine()) != null)
    //         {
    //             if (line.Trim() == start)
    //             {
    //                 insideBlock = true;
    //             }
    //             if(line.Trim() == end)
    //             {
    //                 insideBlock = false;
    //             }
    //             if (insideBlock)
    //             {
    //                 if (!fileContent.Contains(line))
    //                 {
    //                     fileContent.Add(line);
    //                 }
    //             }
    //         }
    //     }
    //     return fileContent;
    // }
    public void ExportUserProfile(User user = null)
    {
        if (user == null)
        {
            using (StreamWriter writer = new StreamWriter(SavedUsersDir))
            {
                foreach (User user1 in this.users)
                {
                    writer.WriteLine("");
                    writer.WriteLine("--new_user--");
                    writer.WriteLine(user1.Info(inclPassword: true));
                    writer.WriteLine("--end_user--");
                }
            }
        }
        else
        {
            using (StreamWriter writer = new StreamWriter(SavedUsersDir, append: true))
            {
                writer.WriteLine("");
                writer.WriteLine("--new_user--");
                writer.WriteLine(user.Info(inclPassword: true));
                writer.WriteLine("--end_user--");
            }
        }
    }
    public void ExportCourse(Course course)
    {

    }
}