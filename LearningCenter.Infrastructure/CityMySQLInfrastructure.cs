using LearningCenter.Infrastructure.Context;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class CityMySQLInfrastructure: ICityInfrastructure
{
    private SignLingoDbContext _signLingoDbContext;

    public CityMySQLInfrastructure(SignLingoDbContext signLingoDbContext)
    {
        _signLingoDbContext = signLingoDbContext;
    }
    
    public List<City> GetAll()
    {
        return _signLingoDbContext.City.ToList();
    }
}