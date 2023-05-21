using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface ITutorialInfrastructure
{
    List<Tutorial> GetAll();
}