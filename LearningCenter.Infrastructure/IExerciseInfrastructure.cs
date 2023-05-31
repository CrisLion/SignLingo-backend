using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface IExerciseInfrastructure
{
    List<Exercise> GetAll();
}