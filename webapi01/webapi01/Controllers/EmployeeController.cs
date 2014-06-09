using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi01.Models;

namespace webapi01.Controllers
{
    public class EmployeeController : ApiController
    {
        // The list expose to the Http clients
        public static List<Employee> list = new List<Employee>()
        {
            new Employee(),
            new Employee(){Id = 1, FirstName = "Kai", LastName = "Zhou"},
            new Employee(){Id = 2, FirstName = "Yaqiao", LastName = "Liu"},
            new Employee(){Id = 3, FirstName = "Jie", LastName = "Xiong"},
            new Employee(){Id = 4, FirstName = "Chengcheng", LastName = "Wan"}
        };

        // The Get(), Post(), Put(), Delete() functions are Actions
        // GET api/employee
        public IEnumerable<Employee> Get()
        {
            return list;
        }

        // GET api/employee/5
        public Employee Get(int id)
        {
            return list.First(x => x.Id == id);
        }

        // POST api/employee
        public void Post(Employee employee)
        {
            int maxId = list.Max(x => x.Id);
            employee.Id = maxId;

            list.Add(employee);
        }

        // PUT api/employee/5
        public void Put(int id, Employee employee)
        {
            int index = list.ToList().FindIndex(x => x.Id == id);
            list[index] = employee;
        }

        // DELETE api/employee/5
        public void Delete(int id)
        {
            Employee employee = Get(id);
            list.Remove(employee);
        }
    }
}