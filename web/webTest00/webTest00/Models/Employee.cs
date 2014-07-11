using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTest00.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool? Married { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = String.Empty;
            LastName = String.Empty;
            Age = 0;
            Married = false;
        }

        public Employee(int id, string firstName, string lastName, int age, bool married)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Married = married;
        }

        // 
        public static List<Employee> empList = new List<Employee>()
        {
            new Employee(){Id = 1, FirstName = "Kai", LastName = "Zhou", Married = false, Age = 27},
            new Employee(){Id = 2, FirstName = "Yaqiao", LastName = "Liu", Married = false, Age = 26},
            new Employee(){Id = 3, FirstName = "Yi", LastName = "Zhao", Married = false, Age = 26},
            new Employee(){Id = 4, FirstName = "Chengcheng", LastName = "Wan", Married = false, Age = 26},
            new Employee(){Id = 5, FirstName = "Yuan", LastName = "Liu", Married = false, Age = 26}
        };
        // any other methods
    }
}