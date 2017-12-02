using AttendanceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAttendanceWPF.ViewModels
{
    public class StartUpViewModel
    {
        private List<SchoolYear> dsschoolyear;
        public List<SchoolYear> dsSchoolYear
        {
            get { return dsschoolyear; }
            set { dsschoolyear = value; }
        }

        private List<SchoolYearTerm> dsschoolterms;
        public List<SchoolYearTerm> dsSchoolTerms
        {
            get { return dsschoolterms; }
            set { dsschoolterms = value; }
        }

        private List<Level> dsschoollevel;
        public List<Level> dsSchoolLevel
        {
            get { return dsschoollevel; }
            set { dsschoollevel = value; }
        }

        private List<Classes> dsschoolclasses;
        public List<Classes> dsSchoolClasses
        {
            get { return dsschoolclasses; }
            set { dsschoolclasses = value; }
        }

    }
}
