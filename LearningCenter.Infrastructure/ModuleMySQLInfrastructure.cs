using LearningCenter.Infrastructure.Context;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Infrastructure;

public class ModuleMySQLInfrastructure : IModuleInfrastructure
{
    private SignLingoDbContext _signLingoDbContext;

    public ModuleMySQLInfrastructure(SignLingoDbContext signLingoDbContext)
    {
        _signLingoDbContext = signLingoDbContext;
    }

    public List<Module> GetAll()
    {
        return _signLingoDbContext.Module.ToList();
    }
}