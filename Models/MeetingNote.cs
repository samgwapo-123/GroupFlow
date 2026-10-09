namespace GroupFlow;

public class MeetingNote
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Date { get; set; } = "";
    public string Topic { get; set; } = "";
    public string Notes { get; set; } = "";
}