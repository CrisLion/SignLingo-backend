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
        return _signLingoDbContext.User.Where(user => user.IsActive).ToList();
    }

    public User GetById(int id)
    {
        var user = _signLingoDbContext.User.Find(id);
        var city = _signLingoDbContext.City.Find(user.CityId);
        user.city = city;
        return user;
    }

    public bool Save(User user)
    {
        _signLingoDbContext.User.Add(user);
        _signLingoDbContext.SaveChanges();
        return true;
    }

    public bool Update(int id, User user)
    {
        _signLingoDbContext.User.Update(user);
        _signLingoDbContext.SaveChanges();
        return true;
    }

    public bool Delete(int id)
    {
        User user = _signLingoDbContext.User.Find(id);

        if (user != null)
        {
            user.IsActive = false;

            _signLingoDbContext.User.Update(user);
            
            _signLingoDbContext.SaveChanges();
            return true;
        }
        return false;
    }
}