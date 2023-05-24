using LearningCenter.Infrastructure;
using LearningCenter.Infrastructure.Models;

namespace LearningCenter.Domain;

public class UserDomain : IUserDomain
{
    private IUserInfrastructure _userInfrastructure;

    public UserDomain(IUserInfrastructure userInfrastructure)
    {
        _userInfrastructure = userInfrastructure;
    }

    public bool Save(User user)
    {
        if (!IsValidData(user)) throw new Exception("must follow the user format");

        return _userInfrastructure.Save(user);
    }

    public bool Update(int id, User user)
    {
        if (!IsValidData(user)) throw new Exception("must follow the user format");
        return _userInfrastructure.Update(id, user);
    }

    public bool Delete(int id)
    {
        if (id < 0) throw new Exception("id must be a int greater than 0");
        return _userInfrastructure.Delete(id);
    }

    private bool IsValidData(User user)
    {
        return user.First_Name.Length > 1 && user.Last_Name.Length > 1 && user.Email.Contains('@') &&
               user.CityId > 0;
    }
}