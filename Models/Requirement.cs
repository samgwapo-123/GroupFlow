namespace GroupFlow;

public class Requirement
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Title { get; set; } = "";
    public string Group { get; set; } = "";
    public bool Completed { get; set; }
}