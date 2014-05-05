using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdInherit00
{
    public class Bird : Animal
    {
        #region "Member Variables"
        private int age;
        private EnuGender gender;

        #endregion

        #region "Public Properties"
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public EnuGender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        #endregion

        #region "Constructors"
        public Bird()
            : base()
        {
            age = 0;
            gender = EnuGender.Unknown;
        }

        public Bird(int id, string name, decimal weight, int age, EnuGender gender)
            : base(id, name, weight)
        {
            this.age = age;
            this.gender = gender;
        }
        #endregion

        #region "Methods"
        override public decimal Eat()
        {
            decimal weightAte = 0m;
            weightAte = 0.2m;

            return weightAte;
        }

        override public string Sound()
        {
            string strSound = String.Empty;
            strSound = gender == EnuGender.Male ? "Ga~, ga~!" : "Ga~~!";

            return strSound;
        }

        #endregion
    }
}
