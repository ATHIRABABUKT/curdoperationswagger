using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using curdoperationswagger.context;
using curdoperationswagger.models;

namespace curdoperationswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly CURDContext _CURDContext;
        public StudentsController(CURDContext CURDContext)
        {

            _CURDContext = CURDContext;
        }


        // GET: api/Students
        [HttpGet]
        public IEnumerable<student> Get()
        {
            return _CURDContext.Students;
        }

        // GET: api/Students/5
        [HttpGet("{id}", Name = "Get")]
        public student Get(int id)
        {
            return _CURDContext.Students.SingleOrDefault(x=>x.StudentId == id );
        }

        // POST: api/Students
        [HttpPost]
        public void Post([FromBody] student student)
        {
            _CURDContext.Students.Add(student);
            _CURDContext.SaveChanges();
        }

        // PUT: api/Students/5
        [HttpPut("{id}")]
        public void Put( int id ,[FromBody] student student)
        {
            student.StudentId = id;
            _CURDContext.Students.Update(student);
            _CURDContext.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CURDContext.Students.FirstOrDefault(x => x.StudentId == id);
            if(item != null)
            {
                _CURDContext.Students.Remove(item);
                _CURDContext.SaveChanges();
            }
        }
    }
}
