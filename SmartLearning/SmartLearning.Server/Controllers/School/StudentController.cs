using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartLearning.Data.Repository.IServices;
using SmartLearning.Shared.Models;
using SmartLearning.Shared.Utility;

namespace SmartLearning.Server.Controllers.School
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository Repository;
        public StudentController(IStudentRepository repository)
        {
            Repository = repository;
        }
        [HttpGet("{page}/{size}/{filter?}")]
        public PaginationModel<Student> Get(int page,int size,string filter)
        {
            page = page == 0 ? 1:page;
            size = size < 10 ? 10 : size;

           
            var items = Repository.Get(page,size);
            var count = 0;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                filter = filter.ToLower();
                Expression<Func<Student, bool>> criteria = s => s.FirstName.ToLower().Contains(filter)
                   || s.LastName.ToLower().Contains(filter)
                   || s.Gender.ToLower().Contains(filter)
                   || s.Nationality.ToLower().Contains(filter)
                   || s.Religion.ToLower().Contains(filter);

               count= Repository.Get(criteria).Count(); 
                items = Repository.Get(criteria,page, size);
              
            }
            else
            {
                count = Repository.Get().Count();
            }
            var model = new PaginationModel<Student>();
            model.Filter = filter;
            model.Page = page;
            model.Size = size;
            model.Count = count;
            model.Items = items;
            return model;
        }

       
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "value";
        }

         
        [HttpPost]
        public void Post([FromBody] Student model)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                Repository.Save();

            }
        }

        
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Student model)
        {
            if (!ModelState.IsValid)
                return;

            var studentInDb = Repository.Get(id);

            if (studentInDb == null)
                return;

            studentInDb.FirstName = model.FirstName;
            studentInDb.LastName = model.LastName;
            studentInDb.DateOfBirth = model.DateOfBirth;
            studentInDb.Gender = model.Gender;
            studentInDb.Nationality = model.Nationality;
            studentInDb.Religion = model.Religion;

            Repository.Save();
        }

         
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var studentInDb = Repository.Get(id);

            if (studentInDb != null)
            {
                Repository.Remove(studentInDb);
                Repository.Save();
            }
        }
    }
}
