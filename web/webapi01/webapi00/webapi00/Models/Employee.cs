using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi00.Models
{
    public class Employee
    {
        #region "Member variables"
        private string firstName;
        private string surName;
        private int age;
        private string department;

        #endregion

        #region "Properties"
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        #endregion

        #region "Constructors"
        public Employee()
        {
            this.firstName = String.Empty;
            this.surName = String.Empty;
            this.age = 0;
            this.department = String.Empty;

        }

        public Employee(string firstName, string surName, int age, string department)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.age = age;
            this.department = department;

        }

        #endregion
    }
}