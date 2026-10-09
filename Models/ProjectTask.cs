namespace GroupFlow;

public class ProjectTask
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public int? MemberId { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string AssignedTo { get; set; } = "";
    public string Status { get; set; } = "To Do";
    public string Priority { get; set; } = "Medium";

    public Member? Member { get; set; }
}