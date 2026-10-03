namespace GroupFlow;

// In-memory data shared by every page (registered in Program.cs).
public class ProjectState
{
    public string Name { get; } = "Flood Alert System";

    public List<Member> Members { get; } = new()
    {
        new Member { Name = "Psalm", Bg = "bg-accent" },
        new Member { Name = "John", Bg = "bg-warn" },
        new Member { Name = "Mark", Bg = "bg-ok" },
        new Member { Name = "Anna", Bg = "bg-bad" },
    };

    public List<ProjectTask> Tasks { get; } = new()
    {
        new() { Id = 1, Title = "Research flood risk factors", AssignedTo = "Mark", Status = "Done", Priority = "Medium" },
        new() { Id = 2, Title = "Define rainfall and river inputs", AssignedTo = "Mark", Status = "Done", Priority = "Low" },
        new() { Id = 3, Title = "Create fuzzy rules", AssignedTo = "Psalm", Status = "Done", Priority = "High" },
        new() { Id = 4, Title = "Design membership functions", AssignedTo = "Psalm", Status = "Done", Priority = "High" },
        new() { Id = 5, Title = "Write problem statement", AssignedTo = "Anna", Status = "Done", Priority = "Low" },
        new() { Id = 6, Title = "Set up C# project", AssignedTo = "John", Status = "Done", Priority = "Medium" },
        new() { Id = 7, Title = "Create WinForms UI", Description = "Input sliders and the alert level display.", AssignedTo = "John", Status = "In Progress", Priority = "High" },
        new() { Id = 8, Title = "Documentation", Description = "Write the report sections and add screenshots.", AssignedTo = "Anna", Status = "To Do", Priority = "Medium" },
        new() { Id = 9, Title = "Final testing", Description = "Run the rainfall and river-level test cases.", AssignedTo = "John", Status = "To Do", Priority = "High" },
    };

    public List<Requirement> Requirements { get; } = new()
    {
        new() { Title = "Problem statement", Group = "Development", Completed = true },
        new() { Title = "Research", Group = "Development", Completed = true },
        new() { Title = "Fuzzy rules", Group = "Development", Completed = true },
        new() { Title = "C# implementation", Group = "Development", Completed = true },
        new() { Title = "Documentation", Group = "Finalization" },
        new() { Title = "Presentation slides", Group = "Finalization" },
        new() { Title = "Demo video", Group = "Finalization" },
        new() { Title = "Final testing", Group = "Finalization" },
    };

    int nextTaskId = 10;

    public int Total => Tasks.Count;
    public int DoneCount => Tasks.Count(t => t.Status == "Done");
    public int Pending => Total - DoneCount;
    public int Progress => Total == 0 ? 0 : DoneCount * 100 / Total;

    public int MemberTotal(string name) => Tasks.Count(t => t.AssignedTo == name);
    public int MemberDone(string name) => Tasks.Count(t => t.AssignedTo == name && t.Status == "Done");

    public void AddTask(ProjectTask task)
    {
        task.Id = nextTaskId++;
        Tasks.Add(task);
    }
}