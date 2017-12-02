using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAttendanceWPF
{
    public class AttendanceViewModel
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int subjectid;
        public int SubjectID
        {
            get { return subjectid; }
            set { subjectid = value; }
        }

        private string subjectname;
        public string SubjectName
        {
            get { return subjectname; }
            set { subjectname = value; }
        }

        private int studentid;
        public int StudentID
        {
            get { return studentid; }
            set { studentid = value; }
        }

        private string studentname;
        public string StudentName
        {
            get { return studentname; }
            set { studentname = value; }
        }


        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime attendancedate;
        public DateTime AttendanceDate
        {
            get { return attendancedate; }
            set { attendancedate = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
    }
}
