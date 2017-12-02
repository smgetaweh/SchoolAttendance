using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceModels
{
    public class SchoolYear
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime yearstartdate;

        public DateTime YearStartDate
        {
            get { return yearstartdate; }
            set { yearstartdate = value; }
        }

        private DateTime yearenddate;

        public DateTime YearEndDate
        {
            get { return yearenddate; }
            set { yearenddate = value; }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }


    }
}
