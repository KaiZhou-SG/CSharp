using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdEvent01
{
    /// <summary>
    /// The abstract base class Animal
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// The Name property.
        /// </summary>
        /// <seealso cref="String"/>
        public string Name { get; set; }
        /// <summary>
        /// The Age property.
        /// </summary>
        /// <seealso cref="int"/>
        public int Age { get; set; }

        /// <summary>
        /// The AnimalType property.
        /// </summary>
        /// <seealso cref="AnimalTypeEnum"/>
        public AnimalTypeEnum AnimalType { get; set; }

        protected virtual delegate void OnAgeChanged(AgeChangedEventArgs ageChangedEventArgs);

        /// <summary>
        /// The default constructor. Initialize the Name property
        /// with a String.Empty value.
        /// </summary>
        public Animal()
        {
            this.Name = String.Empty;
            this.Age = 0;
            this.AnimalType = AnimalTypeEnum.OTHERS;
        }

        /// <summary>
        /// The constructor, with the Name property been
        /// initialized.
        /// </summary>
        /// <param name="name">The value to initialize the Name property</param>
        /// <param name="age">The value to initialize the Age property</param>
        /// <param name="animalType">The value to initialize the AnimalType property</param>
        public Animal(string name, int age, AnimalTypeEnum animalType)
        {
            this.Name = name;
            this.Age = age;
            this.AnimalType = animalType;
        }

        /// <summary>
        /// The Move method of the Animal object. 
        /// </summary>
        /// <returns>The distance in meters the Animal object has moved.</returns>
        public virtual decimal Move()
        {
            decimal moveDistance = 0M;

            return moveDistance;
        }

        
    }
}
