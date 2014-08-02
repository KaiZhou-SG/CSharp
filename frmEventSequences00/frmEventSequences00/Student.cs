using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmEventSequences00
{
    public class Student
    {
        private string sName;
        public string SName { get { return sName; } set { sName = value; } }
        // remember to initialize static members while defining them, because
        // we may use them before initializing the class itself
        public static List<Student> lstStudents = new List<Student>();

        public Student()
        {
            this.sName = String.Empty;
        }

        public Student(string name)
        {
            this.sName = name;
        }

    }
}
