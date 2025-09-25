using App;

class Course
{
    public string Name;
    public List<Assignment> AssignmentList = new List<Assignment>();

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
}