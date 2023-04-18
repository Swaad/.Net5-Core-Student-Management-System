using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLearning.Entities;
using TestLearning.Interfaces;

namespace TestLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //tffghfghfytf
        private readonly ModelContext _db = null;
        private ITestService _itest;
        public TestController(ModelContext db, ITestService itest)
        {
            _db = db;
            _itest = itest;
        }


        [HttpPost("Add-TestInfo")]
        public IActionResult AddTestInfo(Testora testora)
        {
            using (var dbTransaction = _db.Database.BeginTransaction())
            {
                var data = _itest.AddStudent(testora);
                if (data)
                {
                    dbTransaction.Commit();
                    return Ok(true);
                }
                else
                {
                    dbTransaction.Rollback();
                    return Ok(false);
                }
            }
        }

        [HttpGet]
        [Route("get-all-student-info")]
        public List<Testora> GetStudentInfo()
        {
            var data = _itest.GetStudents();
            return data;
        }

        [HttpGet]
        [Route("get-all-student-info/{id}")]
        public object GetStudentById(string id)
        {
            var data = _itest.GetStudentById(id);
            return data;
        }

        [HttpPut("update")]
        public IActionResult Update(Testora model)
        {
            using (var dbTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var data = _itest.Update(model, _db);
                    dbTransaction.Commit();
                                       
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _itest.Delete(id, _db);
            return Ok(data);
        }
    }
}
