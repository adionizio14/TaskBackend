namespace TaskBackend.Models;

public class TaskItem
{
    public long Id {get; set;}

    public string? TaskName {get; set;}

    public string? TaskStatus {get; set;}

    public string? TaskPriority {get; set;}
    public DateOnly? DueDate {get; set;}

    public string? TaskDescription {get; set;}
}