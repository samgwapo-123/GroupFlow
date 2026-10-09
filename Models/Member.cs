namespace GroupFlow;

public class Member
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Name { get; set; } = "";
    public string Bg { get; set; } = "";

    public List<ProjectTask> Tasks { get; set; } = new();
}