using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        
        // GET: api/User
        [HttpGet(Name = "GetUser")]
        public IEnumerable<User> Get()
        {
            return _userInfrastructure.GetAll();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUserById")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userDomain.Save(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            _userDomain.Update(id, user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userDomain.Delete(id);
        }
    }
}
