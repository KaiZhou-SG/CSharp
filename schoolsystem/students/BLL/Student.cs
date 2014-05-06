using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SchoolSystem.Students.DAL;

namespace SchoolSystem.Students.BLL
{
    public class Student
    {
        #region "Private Member Variables"
        private int id;
        private int classId;
        private string name;
        private char gender;
        private int age;
        private int grade;
        #endregion

        #region "Public Properties"
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int ClassID
        {
            get { return classId; }
            set { classId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        #endregion

        #region "Constructors"
        public Student()
        {
            this.id = 0;
            this.classId = 0;
            this.name = String.Empty;
            this.grade = 0;
            this.age = 0;
        }

        public Student(int id, int classId, string name, int grade, int age)
        {
            this.id = id;
            this.classId = classId;
            this.name = name;
            this.grade = grade;
            this.age = age;
        }

        #endregion

        #region "Methods"
        public Student GetStudent(int stuId)
        {
            return StudentDAL.GetStudent(stuId);
        }

        public List<Student> GetAllStudents()
        {
            return StudentDAL.GetAllStudents(); 
        }

        public bool DeleteStudent(int stuId)
        {
            return StudentDAL.DeleteStudent(stuId); 
        }

        // To add relationship between a student with a class
        public bool RegisterStudent(int stuId, int clsId)
        {
            return StudentDAL.RegisterStudent(stuId, clsId);
        }

        // To delete the relationships between a student with 
        // classes
        public bool UnregisterStudent(int stuId)
        {
            return StudentDAL.UnregisterStudent(stuId);
        }

        // To delete the relationship between a student with a class
        public bool UnregisterStudentFromClass(int stuId, int clsId)
        {
            return StudentDAL.UnregisterStudentFromClass(stuId, clsId);
        }
        #endregion
    }
}
