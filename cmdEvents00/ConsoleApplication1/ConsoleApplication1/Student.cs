using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {
        private int grade;
        private string firstName;
        private string lastName;
        private int id;
        public delegate string failed(Student student, FailedEventArgs e);
        public event failed failedHandler;

        public int Grade
        {
            get { return grade; }
            set 
            {
                grade = value;
                if (grade < 60)
                {
                    failedHandler(this, new FailedEventArgs("Oh, no, I failed."));
                }
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int ID 
        {
            get { return id; }
            set { id = value; }
        }

        public Student()
        {
            firstName = String.Empty;
            lastName = String.Empty;
            grade = 0;
            id = 0;

        }

        public Student(string firstName, string lastName, int grade, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
            this.id = id;

        }

    }
}
