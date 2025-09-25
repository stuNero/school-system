using App;

class Course
{
    public string Name;
    public List<Assignment> AssignmentList = new List<Assignment>();
    public List<Student> students = new List<Student>();
    public List<Teacher> teachers = new List<Teacher>();

    public Course(string name)
    {
        Name = name;
    }
    public void AddAssignment(Assignment assignment)
    {
        foreach (Assignment ass in AssignmentList)
        {
            if (assignment.Id == ass.Id)
            {
                return;
            }
        }
        AssignmentList.Add(assignment);
    }
    public void RemoveAssignment(string ID)
    {
        foreach (Assignment ass in AssignmentList)
        {
            if (ID == ass.Id)
            {
                AssignmentList.Remove(ass);
            }
        }
    }
    public void AddUser(User user)
    {
        if (!students.Contains(user) || !teachers.Contains(user))
        {
            if (user is Teacher t)
                {
                    teachers.Add(t);
                }
                else if (user is Student s)
                {
                    students.Add(s);
                }
        }
    }
}