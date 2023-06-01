namespace LearningCenter.Infrastructure.Models;

public class User
{
    public int Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Email { get; set; }
    public int CityId { get; set; }
    
    public City city { get; set; }
    public  bool IsActive { get; set; }
}