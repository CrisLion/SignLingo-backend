namespace LearningCenter.Infrastructure.Models;

public class Exercise
{
    public int Id { get; set; }
    public string Question { get; set; }
    public List<string> Answer { get; set; }
    public int ModuleId { get; set; }
}