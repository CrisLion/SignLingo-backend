namespace LearningCenter.Domain2.Test;
using LearningCenter.Infrastructure.Models;
using LearningCenter.Infrastructure;
using LearningCenter.Domain;
using Moq;

public class UserDomainUnitTest
{
    [Fact]
    public void save_ValidObject_ReturnTrue()
    {
        //Arrange
        var user = new User()
        {
            First_Name = "Juanito",
            Last_Name = "Quito",
            Email = "aa@a.com",
            CityId = 1
        };

        //Mock
        var userInfrastructure = new Mock<IUserInfrastructure>();
        userInfrastructure.Setup(u => u.Save(user)).Returns(true);

        UserDomain userDomain = new UserDomain(userInfrastructure.Object);

        //Act
        var result = userDomain.Save(user);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void update_ValidObject_ReturnTrue()
    {
        //Arrange
        var user = new User()
        {
            First_Name = "Juanito",
            Last_Name = "Quito",
            Email = "aa@a.com",
            CityId = 1
        };
        
        //Mock
        var userInfrastructure = new Mock<IUserInfrastructure>();
        userInfrastructure.Setup(u => u.Update(user.Id, user)).Returns(true);
        
        UserDomain userDomain = new UserDomain(userInfrastructure.Object);
        
        //Act
        var result = userDomain.Update(user.Id, user);
        
        //Assert
        Assert.True(result);
    }
    
    [Fact]
    public void delete_ValidObject_ReturnTrue()
    {
        //Arrange
        int userId = 1;
        
        //Mock
        var userInfrastructure = new Mock<IUserInfrastructure>();
        userInfrastructure.Setup(u => u.Delete(userId)).Returns(true);
        
        UserDomain userDomain = new UserDomain(userInfrastructure.Object);
        
        //Act
        var result = userDomain.Delete(userId);
        
        //Assert
        Assert.True(result);
    }

}