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
        [ActionName("GetEmployeeById")]
        public Employee GetEmployeeById(String id)
        {
            int nId = 0;
            if (Int32.TryParse(id, out nId))
            {
                return new Employee().GetEmployeeById(nId);
            }
            else
            {
                // invalid input
                throw new Exception("Invalid employee id");
            }
        }

        // GET api/<controller>/Zhou
        [ActionName("GetEmployeeByFirstName")]
        public Employee GetEmployeeByFirstName(String firstName)
        {
            return new Employee().GetEmployeeByFirstName(firstName);
        }

        // POST api/<controller>
        public void Post(int id, String firstName, String lastName, String gender)
        {
            new Employee().CreateEmployee(new Employee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender
            }
           );

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