using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCenter.Infrastructure;
using LearningCenter.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        
        private ICityInfrastructure _cityInfrastructure;

        public CityController(ICityInfrastructure cityInfrastructure)
        {
            _cityInfrastructure = cityInfrastructure;
        }
        
        // GET: api/City
        [HttpGet(Name = "GetCity")]
        public IEnumerable<City> Get()
        {
            return _cityInfrastructure.GetAll();
        }

        // GET: api/City/5
        [HttpGet("{id}", Name = "GetCityById")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/City
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/City/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/City/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
