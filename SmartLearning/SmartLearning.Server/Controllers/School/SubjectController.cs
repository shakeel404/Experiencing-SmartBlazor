using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartLearning.Data.Repository.IServices;
using SmartLearning.Shared;
using SmartLearning.Shared.Models;

namespace SmartLearning.Server.Controllers.School
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository Repository;
        public SubjectController(ISubjectRepository repository)
        {
            Repository = repository;
        }
        
        [HttpGet()]
        public IEnumerable<Subject> Get()
        {
            return Repository.Get();
        }

        // GET: api/Subject/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void Post([FromBody] Subject model)
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
            var subjectToRemove = Repository.Get(id);

            if (subjectToRemove != null)
            {
                Repository.Remove(subjectToRemove);
                Repository.Save(); 
            }
        }
    }
}
