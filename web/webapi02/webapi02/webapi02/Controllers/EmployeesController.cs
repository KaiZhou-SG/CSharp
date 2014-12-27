using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi02.Models;

namespace webapi02.Controllers
{
    public class EmployeesController : ApiController
    {
        #region "Actions"
        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            return new Employee().GetAllEmployees();
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            return new Employee().GetEmployeeById(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Employee value)
        {
            new Employee().CreateEmployee(value);

            return;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Employee value)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }

        #endregion
    }
}