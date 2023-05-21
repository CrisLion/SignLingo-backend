using LearningCenter.Infrastructure.Context;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class CountryMySQLInfrastructure : ICountryInfrastructure
{
    private SignLingoDbContext _signLingoDbContext;

    public CountryMySQLInfrastructure(SignLingoDbContext signLingoDbContext)
    {
        _signLingoDbContext = signLingoDbContext;
    }

    public List<Country> GetAll()
    {
        return _signLingoDbContext.Country.ToList();
    }
}