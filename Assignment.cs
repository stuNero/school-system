using App;

class Assignment
{
    public string Name;
    public string Id;
    string Content;
    
    public Assignment(string name, string id)
    {
        Name = name;
        Id = id;
    }
    public void addContent(string text)
    {
        this.Content += text;
    }
}