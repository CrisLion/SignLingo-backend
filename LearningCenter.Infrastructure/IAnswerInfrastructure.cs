using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public interface IAnswerInfrastructure
{
    List<Answer> GetAll();
}