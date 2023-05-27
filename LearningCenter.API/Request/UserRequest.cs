using System.ComponentModel.DataAnnotations;

namespace LearningCenter.API.Request;

public class UserRequest
{
    [Required]
    [MaxLength(30)]
    [MinLength(2)]
    public string First_Name { get; set; }
    
    [Required]
    [MaxLength(30)]
    [MinLength(2)]
    public string Last_Name { get; set; }
    
    [Required]
    [MaxLength(30)]
    [MinLength(2)]
    public string Email { get; set; }
    
    [Required]
    public int City { get; set; }
}