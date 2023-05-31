using LearningCenter.Infrastructure.Context;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class ExerciseMySQLInfrastructure : IExerciseInfrastructure
{
    private SignLingoDbContext _signLingoDbContext;

    public ExerciseMySQLInfrastructure(SignLingoDbContext signLingoDbContext)
    {
        _signLingoDbContext = signLingoDbContext;
    }

    public List<Exercise> GetAll()
    {
        return _signLingoDbContext.Exercise.ToList();
    }
}