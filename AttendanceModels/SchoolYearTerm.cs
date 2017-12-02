using System;

namespace AttendanceModels
{
    public class SchoolYearTerm
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int schoolyearid;
        public int SchoolYearID
        {
            get { return schoolyearid; }
            set { schoolyearid = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private decimal attendancedaysrequire;
        public decimal AttendanceDaysRequire
        {
            get { return attendancedaysrequire; }
            set { attendancedaysrequire = value; }
        }
        
        private DateTime startofterm;
        public DateTime StartOfTerm
        {
            get { return startofterm; }
            set { startofterm = value; }
        }

        private DateTime startofhalfterm;
        public DateTime StartOfHalfTerm
        {
            get { return startofhalfterm; }
            set { startofhalfterm = value; }
        }

        private DateTime endofhalfterm;
        public DateTime EndOfHalfTerm
        {
            get { return endofhalfterm; }
            set { endofhalfterm = value; }
        }

        private DateTime endofterm;
        public DateTime EndOfTerm
        {
            get { return endofterm; }
            set { endofterm = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }



    }

}
