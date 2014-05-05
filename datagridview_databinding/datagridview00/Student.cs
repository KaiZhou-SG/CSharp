using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datagridview00
{
    /// <summary>
    /// Student Class represent a 
    /// student at school
    /// </summary>
    class Student
    {
        #region "Member Variables"

        private string name;
        private Gender gender;
        private Int32 age;

        #endregion

        #region "Properties"
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Gender Gender_
        {
            get { return gender; }
            set { gender = value; }
        }
        public Int32 Age
        {
            get { return age; }
            set { age = value; }
        }

        #endregion

        #region "Constructors"
        public Student()
        {
            name = String.Empty;
            gender = Gender.male;
            age = 0;
        }

        public Student(string name, Gender gender, Int32 age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        #endregion
    }

    enum Gender
    {
        male,
        femal
    };
}
