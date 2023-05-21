using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface ICityInfrastructure
{
    List<City> GetAll();
}