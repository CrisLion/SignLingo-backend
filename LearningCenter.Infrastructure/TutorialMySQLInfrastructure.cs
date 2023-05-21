using LearningCenter.Infrastructure.Context;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class TutorialMySQLInfrastructure : ITutorialInfrastructure
{

    private LearningCenterDBContext _learningCenterDbContext;

    public TutorialMySQLInfrastructure(LearningCenterDBContext learningCenterDbContext)
    {
        _learningCenterDbContext = learningCenterDbContext;
    }

    public List<Tutorial> GetAll()
    {
        return _learningCenterDbContext.Tutorials.ToList();
    }
}