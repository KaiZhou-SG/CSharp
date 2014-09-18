using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_principle01.helpers;
using _02_principle01.behavior;

namespace _02_principle01.baseclass
{
    /// <summary>
    /// The base class of all people in the company, 
    /// including all employers and employees
    /// </summary>
    public class People
    {
        private string firstName;
        private string lastName;
        private int id;
        private Title title;

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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Title _Title
        {
            get { return title; }
            set { title = value; }
        }

        private iWork work;
        private iEarnMoney earnMoney;
        private iFinanceReport report;

        public People()
        {
            firstName = String.Empty;
            lastName = String.Empty;
            id = 0;
            title = Title.Unknown;
            work = null;
            earnMoney = null;
            report = null;
        }

        public People(string fName, string lName, int id,
            Title title, iWork work, 
            iEarnMoney earnMoney,
            iFinanceReport report)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.id = id;
            this.title = title;
            this.work = work;
            this.earnMoney = earnMoney;
            this.report = report;
        }

        public string performWork()
        {
            return work.work();
        }

        public string performFinanceReport()
        {
            return report.financeReport();
        }

        public decimal performEarnMoney()
        {
            return earnMoney.earnMoney();
        }
    }
}
