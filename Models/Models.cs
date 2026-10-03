namespace GroupFlow;

public class Member
{
    public string Name { get; set; } = "";
    public string Bg { get; set; } = "";
}

public class ProjectTask
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string AssignedTo { get; set; } = "";
    public string Status { get; set; } = "To Do";
    public string Priority { get; set; } = "Medium";
}

public class Requirement
{
    public string Title { get; set; } = "";
    public string Group { get; set; } = "";
    public bool Completed { get; set; }
}