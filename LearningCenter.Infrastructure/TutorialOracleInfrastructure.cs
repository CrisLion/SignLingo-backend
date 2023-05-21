using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class TutorialOracleInfrastructure : ITutorialInfrastructure
{
    public List<Tutorial> GetAll()
    {
        string[] arr = { "Oracle Server 1", "Oracle Server 2", "Oracle Server 3" };
        return null;
    }
}