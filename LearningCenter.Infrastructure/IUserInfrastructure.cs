using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface IUserInfrastructure
{
    List<User> GetAll();
}