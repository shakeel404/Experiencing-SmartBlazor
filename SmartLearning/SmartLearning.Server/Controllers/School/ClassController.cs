using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartLearning.Data.Repository.IServices;
using SmartLearning.Shared.Models;

namespace SmartLearning.Server.Controllers.School
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {

        private readonly IClassRepository Repository;
        public ClassController(IClassRepository repository)
        {
            Repository = repository;
        }
         
        [HttpGet]
        public IEnumerable<Class> Get()
        {
            return Repository.Get();
        }
         
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
          
        [HttpPost]
        public void  Post([FromBody] Class model)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                Repository.Save();
            } 
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var classToRemove = Repository.Get(id);

            if (classToRemove != null)
            {
                Repository.Remove(classToRemove);
                Repository.Save();
            }
                
        }
    }
}
