using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi00.Models;

namespace webapi00.Controllers
{
    /// <summary>
    /// 2014-07-11 Zhou Kai tries out to write codes on
    /// an empty asp.net web api 2 project
    /// </summary>
    public class EmployeeController : ApiController
    {
        // an in-memory list
        public List<Employee> lstAllEmployees = new List<Employee> { 
            new Employee("Kai", "Zhou", 27, "Developer"),
            new Employee("Yaqiao", "Liu", 26, "Accountant"),
            new Employee("Chenchen", "Wan", 26, "Student"),
            new Employee("Jie", "Xiong", 26, "Teacher")
        };

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return lstAllEmployees;
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            List<Employee> lst = new List<Employee> { new Employee()};
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
