using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Teacher
    {
        public Teacher()
        {
 
        }

        public string RemindFailure(Student student, FailedEventArgs e)
        {
            string message =
                "Dear " + student.FirstName + " " + student.LastName + "," +
                " sorry, you have failed the exam. Your grade is: " + 
                student.Grade.ToString() + " and this is what you said: " + 
                e.ToString();

            Console.WriteLine(message);

            return message;
        }
    }
}
