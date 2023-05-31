using LearningCenter.Infrastructure.Context;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class AnswerMySQLInfrastructure : IAnswerInfrastructure
{
    private SignLingoDbContext _signLingoDbContext;

    public AnswerMySQLInfrastructure(SignLingoDbContext signLingoDbContext)
    {
        _signLingoDbContext = signLingoDbContext;
    }

    public List<Answer> GetAll()
    {
        return _signLingoDbContext.Answers.ToList();
    }
}