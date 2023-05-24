using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface IUserInfrastructure
{
    List<User> GetAll();
    public bool Save(User user);
    public bool Update(int id, User user);
    public bool Delete(int id);
}