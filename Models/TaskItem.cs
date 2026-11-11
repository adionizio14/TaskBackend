namespace TaskBackend.Models;

public class TaskItem
{
    public long Id {get; set;}

    public string? Name {get; set;}

    public string? Status {get; set;}

    public string? Priority {get; set;}
    public DateOnly? DueDate {get; set;}

    public string? Description {get; set;}
}