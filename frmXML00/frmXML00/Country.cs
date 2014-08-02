using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmXML00
{
    public class Country
    {
        #region "Private member variables"
        private string countryName;
        private decimal gdpPerPerson;
        private DateTime nationalDay;
        private double area;
        private long population;

        #endregion

        #region "Public properties"
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        public decimal GDPPerPerson
        {
            get { return gdpPerPerson; }
            set { gdpPerPerson = value; }
        }
        public DateTime NationalDay
        {
            get { return nationalDay; }
            set { nationalDay = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public long Population
        {
            get { return population; }
            set { population = value; }
        }

        #endregion

        #region "Constructors"
        public Country()
        {
            this.countryName = String.Empty;
            this.gdpPerPerson = 0M;
            this.nationalDay = DateTime.Now;
            this.area = 0D;
            this.population = 0L;
        }

        public Country(string countryName, decimal gdpPerPerson, 
            DateTime nationalDay, double area, long population)
        {
            this.countryName = countryName;
            this.gdpPerPerson = gdpPerPerson;
            this.nationalDay = nationalDay;
            this.area = area;
            this.population = population;
        }

        #endregion

        #region "Methods"
        public List<Country> GetAllCountries()
        {
            return new List<Country>() 
            { new Country("US", 99999, Convert.ToDateTime("1776-07-04"), 99999, 99999),
               new Country("UK", 88888, Convert.ToDateTime("1000-01-01"), 20000, 20000),
               new Country("China", 111, Convert.ToDateTime("1949-10-10"), 99999, 9999999),
               new Country("Singapore", 44444, Convert.ToDateTime("1965-08-07"), 111, 111)
            };
        }
        #endregion
    }
}
