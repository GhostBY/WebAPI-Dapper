using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Dapper.Models.Entities;
using WebAPI_Dapper.Models.Interfaces;
using WebAPI_Dapper.Models.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_Dapper.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IRepository<Client> _clientRepository = new ClientRepository();
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientRepository.GetAll();
        }
        // GET: api/values
       
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Create([FromBody]Client client)
        {
            _clientRepository.Create(client);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut]
        public void Update([FromBody]Client client)
        {
            _clientRepository.Update(client);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Remove(int Id)
        {
            _clientRepository.Remove(Id);
            }
    }
}
