using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Attendance_System.Models;
using System.Data;

namespace Attendance_System.Controllers
{
	public partial class GridController : Controller
    {
        private Attendance_Sys_Entities db = new Attendance_Sys_Entities();
        private int Cls_Sch_ID = 0;
        public ActionResult ClassSubject_Read([DataSourceRequest]DataSourceRequest request)
		{
            var result = db.GetSubjectByClassId().ToList();

			return Json(result.ToDataSourceResult(request));
		}
        public ActionResult Student_Read([DataSourceRequest]DataSourceRequest request,string ClassScheduleID)
        {
            Cls_Sch_ID = Convert.ToInt32(ClassScheduleID);
            var result = db.GetStudentByClassScheduleId(Cls_Sch_ID).ToList();

            return Json(result.ToDataSourceResult(request));
        }
        public ActionResult Student_Create([DataSourceRequest]DataSourceRequest request, Student st)
        {
            
            db.InsertStudent(st.FirstName, st.MiddleName, st.LastName, st.Gender, st.DateofBirth, st.AddressLine1, st.AddressLine2, st.City, st.Country, Convert.ToInt32(st.PhoneNo), 1,"P");
            db.SaveChanges();
            var result = db.GetStudentByClassScheduleId(Cls_Sch_ID).ToList();
            return Json(result.ToDataSourceResult(request));
        }
        public ActionResult Student_Update([DataSourceRequest]DataSourceRequest request, Student st)
        {
            db.UpdateStudentDetails(Convert.ToInt32(st.StudentID),st.FirstName,st.MiddleName,st.LastName,st.Gender,st.DateofBirth,st.AddressLine1,st.AddressLine2,st.City,st.Country,Convert.ToInt32(st.PhoneNo));
            db.SaveChanges();
            var result = db.GetStudentByClassScheduleId(Cls_Sch_ID).ToList();
            return Json(result.ToDataSourceResult(request));
        }
        public ActionResult Student_Destroy([DataSourceRequest]DataSourceRequest request, string StudentID,string AttendanceID)
        {
            var stID = Convert.ToInt32(StudentID);
            Student st = db.Students.Find(stID);
            if (st == null)
            {
                return Json("Student Not Found");
            }

            db.Students.Remove(st);
            db.SaveChanges();
            //var stID = Convert.ToInt32(StudentID);
            //db.DeleteStudent(stID);
            //db.SaveChanges();
            var result = db.GetStudentByClassScheduleId(Cls_Sch_ID).ToList();
            return Json(result.ToDataSourceResult(request));
        }
    }
}
