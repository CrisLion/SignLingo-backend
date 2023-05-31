using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface IModuleInfrastructure
{
    List<Module> GetAll();
}