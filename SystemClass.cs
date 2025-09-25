namespace App;

class SystemClass
{
    public List<User> users = new List<User>();
    public Dictionary<string, List<User>> attendeesByCourse = new Dictionary<string, List<User>>();

    public List<string> CheckCourses(User user)
    {
        List<string> courseList = new List<string>();
        foreach ((string course, List<User> users1) in attendeesByCourse)
        {
            foreach (User user1 in users1)
            {
                if (user == user1)
                {
                    courseList.Add(course);
                }
            }
        }
        if (courseList.Count == 0)
        {
            Utility.Error("Du är inte registrerad på några kurser");
        }
        return courseList;
    }
}