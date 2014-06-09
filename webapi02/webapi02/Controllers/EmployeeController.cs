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
            new Employee(){Id = 1, FirstName = "Kai", LastName = "Zhou", Department = 1},
            new Employee(){Id = 2, FirstName = "Yaqiao", LastName = "Liu", Department = 3},
            new Employee(){Id = 3, FirstName = "Jie", LastName = "Xiong", Department = 1},
            new Employee(){Id = 4, FirstName = "Chengcheng", LastName = "Wan", Department = 2}
        };

        // The Get(), Post(), Put(), Delete() functions are Actions
        // GET api/employee
        public IEnumerable<Employee> Get()
        {
            return list;
        }

        // Actions 
        public Employee Get(int id)
        {
            var employee = list.FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }

        public IEnumerable<Employee> GetByDepartment(int department)
        {
            int[] validDepartments = { 1, 2, 3, 5, 8, 13 };

            if (!validDepartments.Any(d => d == department))
            {
                var response = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422, // unprocessable entity
                    ReasonPhrase = "Invalid Department"
                };

                throw new HttpResponseException(response);
            }

            return list.Where(x => x.Department == department);
        }

    }

    public class Filter
    {
        public int Department { get; set; }
        public string LastName { get; set; }
    }
}