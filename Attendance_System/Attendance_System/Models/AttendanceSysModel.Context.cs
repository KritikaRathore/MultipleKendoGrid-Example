﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Attendance_Sys_Entities : DbContext
    {
        public Attendance_Sys_Entities()
            : base("name=Attendance_Sys_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Class_Schedule> Class_Schedule { get; set; }
        public DbSet<Class_Tbl> Class_Tbl { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    
        public virtual int DeleteStudent(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStudent", studentIdParameter);
        }
    
        public virtual ObjectResult<GetStudentByClassScheduleId_Result> GetStudentByClassScheduleId(Nullable<int> classScheduleId)
        {
            var classScheduleIdParameter = classScheduleId.HasValue ?
                new ObjectParameter("ClassScheduleId", classScheduleId) :
                new ObjectParameter("ClassScheduleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentByClassScheduleId_Result>("GetStudentByClassScheduleId", classScheduleIdParameter);
        }
    
        public virtual ObjectResult<GetSubjectByClassId_Result> GetSubjectByClassId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSubjectByClassId_Result>("GetSubjectByClassId");
        }
    
        public virtual int InsertStudent(string firstName, string middleName, string lastName, string gender, Nullable<System.DateTime> dOB, string addressLine1, string addressLine2, string city, string country, Nullable<int> phoneNo, Nullable<int> classSchID, string att)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var phoneNoParameter = phoneNo.HasValue ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(int));
    
            var classSchIDParameter = classSchID.HasValue ?
                new ObjectParameter("ClassSchID", classSchID) :
                new ObjectParameter("ClassSchID", typeof(int));
    
            var attParameter = att != null ?
                new ObjectParameter("Att", att) :
                new ObjectParameter("Att", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertStudent", firstNameParameter, middleNameParameter, lastNameParameter, genderParameter, dOBParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, countryParameter, phoneNoParameter, classSchIDParameter, attParameter);
        }
    
        public virtual int UpdateStudentDetails(Nullable<int> studentID, string firstName, string middleName, string lastName, string gender, Nullable<System.DateTime> dOB, string addressLine1, string addressLine2, string city, string country, Nullable<int> phoneNo)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var phoneNoParameter = phoneNo.HasValue ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStudentDetails", studentIDParameter, firstNameParameter, middleNameParameter, lastNameParameter, genderParameter, dOBParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, countryParameter, phoneNoParameter);
        }
    }
}