//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Attendance_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Class_Schedule
    {
        public Class_Schedule()
        {
            this.Attendances = new HashSet<Attendance>();
        }
    
        public int ClassScheduleID { get; set; }
        public int ClassID { get; set; }
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
    
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Class_Tbl Class_Tbl { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
