using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dgv00
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Gender _Gender { get; set; }

        public Employee()
        {
            Name = String.Empty;
            Id = 0;
            _Gender = Gender.Male;
        }

        public Employee(string name, int id, Gender gender)
        {
            this.Name = name;
            this.Id = id;
            this._Gender = gender;
        }

    }
}
