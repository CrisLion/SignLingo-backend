using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface ICountryInfrastructure
{
    List<Country> GetAll();
}