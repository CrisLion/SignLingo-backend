    namespace LearningCenter.Infrastructure.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Tutorial> Tutorials { get; set; }
}