using LearningCenter.Infrastructure.Context;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class UserMySQLInfrastructure : IUserInfrastructure
{
    private SignLingoDbContext _signLingoDbContext;

    public UserMySQLInfrastructure(SignLingoDbContext signLingoDbContext)
    {
        _signLingoDbContext = signLingoDbContext;
    }
    
    public List<User> GetAll()
    {
        return _signLingoDbContext.User.ToList();
    }
}