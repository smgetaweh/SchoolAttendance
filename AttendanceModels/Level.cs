namespace AttendanceModels
{
    public class Level
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int schooltermid;

        public int SchoolTermID
        {
            get { return schooltermid; }
            set { schooltermid = value; }
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
