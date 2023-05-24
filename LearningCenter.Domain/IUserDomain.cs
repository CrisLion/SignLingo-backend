using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Domain;

public interface IUserDomain
{
    public bool Save(User user);
    public bool Update(int id, User user);
    public bool Delete(int id);
}