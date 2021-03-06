//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolAttendanceWPF.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSchoolYearTerm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSchoolYearTerm()
        {
            this.tblSchoolLevel = new HashSet<tblSchoolLevel>();
        }
    
        public int ID { get; set; }
        public Nullable<int> SchoolYearID { get; set; }
        public string Description { get; set; }
        public Nullable<int> AttendanceDaysRequirement { get; set; }
        public Nullable<System.DateTime> StartOfTerm { get; set; }
        public Nullable<System.DateTime> StartOfHalfTerm { get; set; }
        public Nullable<System.DateTime> EndOfHalfTerm { get; set; }
        public Nullable<System.DateTime> EndOfTerm { get; set; }
        public string Notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchoolLevel> tblSchoolLevel { get; set; }
        public virtual tblSchoolYear tblSchoolYear { get; set; }
    }
}
