namespace GroupFlow;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public List<Member> Members { get; set; } = new();
    public List<ProjectTask> Tasks { get; set; } = new();
    public List<Requirement> Requirements { get; set; } = new();
    public List<MeetingNote> MeetingNotes { get; set; } = new();
}