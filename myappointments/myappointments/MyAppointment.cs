using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Scheduler;

namespace MyAppointments
{
    public class MyAppointment
    {
        /*
         * 2013-08-01 Zhou Kai write class MyAppointment to
         * be attached to an appointment object for the 
         * Scheduler Control of the DevExpress
         * 
         */

        #region "Private Variables"

        private string m_subject;
        private string m_start_location;
        private string m_end_location;
        private DateTime m_start_datetime;
        private DateTime m_end_datetime;
        private string m_description;

        #endregion

        #region "Constructors"

        public MyAppointment()
        {
 
        }

        public MyAppointment(string subject, string start_location, string end_location,
                             DateTime start_datetime, DateTime end_datetime, string description)
        {
            m_subject = subject;
            m_start_location = start_location;
            m_end_location = end_location;
            m_start_datetime = start_datetime;
            m_end_datetime = end_datetime;
            m_description = description;
        }

        #endregion

        #region "Properties"

        public string Subject
        {
            get { return m_subject; }
            set { m_subject = value; }
        }
        public string StartLocation
        {
            get { return m_start_location; }
            set { m_start_location = value; }
        }
        public string EndLocation
        {
            get { return m_end_location; }
            set { m_end_location = value; }
        }
        public DateTime StartDateTime
        {
            get { return m_start_datetime; }
            set { m_start_datetime = value; }
        }
        public DateTime EndDateTime
        {
            get { return m_end_datetime; }
            set { m_end_datetime = value; }
        }
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }
        #endregion


        #region "Methods"

        #endregion


    }
}
