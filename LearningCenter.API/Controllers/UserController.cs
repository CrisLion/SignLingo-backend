using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCenter.API.Request;
using LearningCenter.API.Response;
using LearningCenter.Domain;
using LearningCenter.Infrastructure;
using LearningCenter.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private IUserInfrastructure _userInfrastructure;
        private IUserDomain _userDomain;

        public UserController(IUserInfrastructure userInfrastructure, IUserDomain userDomain)
        {
            _userInfrastructure = userInfrastructure;
            _userDomain = userDomain;
        }
        
        // GET: api/LearningCenter.Domain.Test
        [HttpGet(Name = "GetUser")]
        public IEnumerable<User> Get()
        {
            return _userInfrastructure.GetAll();
        }

        // GET: api/LearningCenter.Domain.Test/5
        [HttpGet("{id}", Name = "GetUserById")]
        public UserResponse Get(int id)
        {
            var user = _userInfrastructure.GetById(id);
            var userResponse = new UserResponse()
            {
                Id = user.Id,
                First_Name = user.First_Name,
                Last_Name = user.Last_Name,
                Email = user.Email,
                CityID = user.CityId
            };

            return userResponse;
        }

        // POST: api/LearningCenter.Domain.Test
        [HttpPost]
        public void Post([FromBody] UserRequest userRequest)
        {

            if (ModelState.IsValid)
            {
                //Temporal
                var user = new User()
                {
                    First_Name = userRequest.First_Name,
                    Last_Name = userRequest.Last_Name,
                    Email = userRequest.Email,
                    CityId = userRequest.City
                };
            
                _userDomain.Save(user);
            }
            else
            {
                StatusCode(400);
            }
            
        }

        // PUT: api/LearningCenter.Domain.Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            _userDomain.Update(id, user);
        }

        // DELETE: api/LearningCenter.Domain.Test/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userDomain.Delete(id);
        }
    }
}
