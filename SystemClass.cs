namespace App;

class SystemClass
{
    public List<User> users = new List<User>();
    public List<Course> courses = new List<Course>();

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
}