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
    public class CountryController : ControllerBase
    {

        private ICountryInfrastructure _countryInfrastructure;

        public CountryController(ICountryInfrastructure countryInfrastructure)
        {
            _countryInfrastructure = countryInfrastructure;
        }
        
        // GET: api/Country
        [HttpGet(Name = "GetCountry")]
        public IEnumerable<Country> Get()
        {
            return _countryInfrastructure.GetAll();
        }

        // GET: api/Country/5
        [HttpGet("{id}", Name = "GetCountryById")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Country
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Country/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Country/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
