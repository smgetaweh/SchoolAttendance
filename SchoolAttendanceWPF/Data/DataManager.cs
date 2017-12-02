using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceModels;

namespace SchoolAttendanceWPF.Data
{
    public class DataManager
    {

        public static async Task<List<AttendanceViewModel>> GetAllAttendanceAsync()
        {
            List<AttendanceViewModel> results = new List<AttendanceViewModel>();
            await Task.Run(() =>
             {
                 using (var db = new dbSchoolAttendanceEntities())
                 {
                     var lstAttendances = db.tblSubjectAttendance.ToList();
                     if (lstAttendances.Count > 0)
                     {
                         foreach (var at in lstAttendances)
                         {
                             AttendanceViewModel exAttendance = new AttendanceViewModel();
                             exAttendance.ID = at.ID;
                             exAttendance.SubjectID = Convert.ToInt32(at.SubjectID);
                             exAttendance.SubjectName = string.Format("({0}) {1}", at.SubjectID, at.tblClassSubject.Description);
                             exAttendance.StudentID = Convert.ToInt32(at.StudentID);
                             exAttendance.StudentName = string.Format("({0}) {1}", at.StudentID, at.tblStudent.Name);
                             exAttendance.Status = at.Status;
                             exAttendance.AttendanceDate = Convert.ToDateTime(at.AttendanceDate);
                             exAttendance.Notes = at.Notes;

                             results.Add(exAttendance);
                         }
                     }
                 }
             });

            return results;
        }


        public static async Task<List<SchoolYear>> GetSchoolYearsAsync()
        {
            List<SchoolYear> lstResults = new List<SchoolYear>();
            await Task.Run(() =>
            {
                using (var db = new dbSchoolAttendanceEntities())
                {
                    var dbresult = db.tblSchoolYear.ToList();
                    if (dbresult.Count > 0)
                    {
                        foreach (var year in dbresult)
                        {
                            SchoolYear exSchoolYear = new SchoolYear();
                            exSchoolYear.ID = year.ID;
                            exSchoolYear.YearEndDate = Convert.ToDateTime(year.YearStartDate);
                            exSchoolYear.YearEndDate = Convert.ToDateTime(year.YearEndDate);
                            exSchoolYear.Description = year.Description;
                            exSchoolYear.Notes = year.Notes;

                            lstResults.Add(exSchoolYear);
                        }
                    }
                }

            });

            return lstResults;
        }

        public static async Task<List<SchoolYearTerm>> GetSchoolYearsTermsAsync(int schoolyearid)
        {
            List<SchoolYearTerm> lstResults = new List<SchoolYearTerm>();
            await Task.Run(() =>
            {
                using (var db = new dbSchoolAttendanceEntities())
                {
                    var dbresult = (from t in db.tblSchoolYearTerm.Where(trm => trm.SchoolYearID == schoolyearid) select t).ToList();
                    if (dbresult.Count > 0)
                    {
                        foreach (var term in dbresult)
                        {
                            SchoolYearTerm exSchoolYearTerm = new SchoolYearTerm();
                            exSchoolYearTerm.ID = term.ID;
                            exSchoolYearTerm.SchoolYearID = Convert.ToInt32(term.SchoolYearID);
                            exSchoolYearTerm.Description = term.Description;
                            exSchoolYearTerm.AttendanceDaysRequire = Convert.ToDecimal(term.AttendanceDaysRequirement);
                            exSchoolYearTerm.StartOfTerm = Convert.ToDateTime(term.StartOfTerm);
                            exSchoolYearTerm.StartOfHalfTerm = Convert.ToDateTime(term.StartOfHalfTerm);
                            exSchoolYearTerm.EndOfHalfTerm = Convert.ToDateTime(term.EndOfHalfTerm);
                            exSchoolYearTerm.EndOfTerm = Convert.ToDateTime(term.EndOfTerm);
                            exSchoolYearTerm.StartOfTerm = Convert.ToDateTime(term.StartOfTerm);
                            exSchoolYearTerm.Notes = term.Notes;

                            lstResults.Add(exSchoolYearTerm);
                        }
                    }
                }

            });

            return lstResults;
        }

        public static async Task<List<Level>> GetAllTermLevelsAsync(int termid)
        {
            List<Level> lstResult = new List<Level>();
            await Task.Run(() =>
            {
                using (var db = new dbSchoolAttendanceEntities())
                {
                    var dbResults = (from level in db.tblSchoolLevel.Where(lvl => lvl.SchoolTermID == termid) select level).ToList();
                    if (dbResults.Count > 0)
                    {
                        foreach (var lvl in dbResults)
                        {
                            Level exLevel = new Level();
                            exLevel.ID = lvl.ID;
                            exLevel.SchoolTermID = Convert.ToInt32(lvl.SchoolTermID);
                            exLevel.Description = lvl.Description;
                            exLevel.Notes = lvl.Notes;

                            lstResult.Add(exLevel);
                        }
                    }
                }
            });
            return lstResult;
        }

        public static async Task<List<Classes>> GetAllLevelsClassAsync(int levelid)
        {
            List<Classes> lstResult = new List<Classes>();
            await Task.Run(() =>
            {
                using (var db = new dbSchoolAttendanceEntities())
                {
                    var dbResults = (from cls in db.tblSchoolClass.Where(clss => clss.SchoolLevelID == levelid) select cls).ToList();
                    if (dbResults.Count > 0)
                    {
                        foreach (var clss in dbResults)
                        {
                            Classes exClass = new Classes();
                            exClass.ID = clss.ID;
                            exClass.LevelID = Convert.ToInt32(clss.SchoolLevelID);
                            exClass.Description = clss.Description;
                            exClass.Notes = clss.Notes;

                            lstResult.Add(exClass);
                        }
                    }
                }
            });
            return lstResult;
        }


    }
}
