﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeePortal_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Emp_Portal : DbContext
    {
        public Emp_Portal()
            : base("name=Emp_Portal")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<employee> employees { get; set; }
    
        public virtual int usp_DeleteEmployee(Nullable<int> iP1)
        {
            var iP1Parameter = iP1.HasValue ?
                new ObjectParameter("IP1", iP1) :
                new ObjectParameter("IP1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteEmployee", iP1Parameter);
        }
    
        public virtual int usp_insertdetail(Nullable<int> iP1, string iP2, string iP3, Nullable<int> iP4, string iP5)
        {
            var iP1Parameter = iP1.HasValue ?
                new ObjectParameter("IP1", iP1) :
                new ObjectParameter("IP1", typeof(int));
    
            var iP2Parameter = iP2 != null ?
                new ObjectParameter("IP2", iP2) :
                new ObjectParameter("IP2", typeof(string));
    
            var iP3Parameter = iP3 != null ?
                new ObjectParameter("IP3", iP3) :
                new ObjectParameter("IP3", typeof(string));
    
            var iP4Parameter = iP4.HasValue ?
                new ObjectParameter("IP4", iP4) :
                new ObjectParameter("IP4", typeof(int));
    
            var iP5Parameter = iP5 != null ?
                new ObjectParameter("IP5", iP5) :
                new ObjectParameter("IP5", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_insertdetail", iP1Parameter, iP2Parameter, iP3Parameter, iP4Parameter, iP5Parameter);
        }
    
        public virtual ObjectResult<USP_SEARCHDEPARTMENT_Result> USP_SEARCHDEPARTMENT(Nullable<int> iP1)
        {
            var iP1Parameter = iP1.HasValue ?
                new ObjectParameter("IP1", iP1) :
                new ObjectParameter("IP1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_SEARCHDEPARTMENT_Result>("USP_SEARCHDEPARTMENT", iP1Parameter);
        }
    
        public virtual int usp_UpdateEmployeeDetails(Nullable<int> iP1, string iP2, string iP3, Nullable<int> iP4, string iP5)
        {
            var iP1Parameter = iP1.HasValue ?
                new ObjectParameter("IP1", iP1) :
                new ObjectParameter("IP1", typeof(int));
    
            var iP2Parameter = iP2 != null ?
                new ObjectParameter("IP2", iP2) :
                new ObjectParameter("IP2", typeof(string));
    
            var iP3Parameter = iP3 != null ?
                new ObjectParameter("IP3", iP3) :
                new ObjectParameter("IP3", typeof(string));
    
            var iP4Parameter = iP4.HasValue ?
                new ObjectParameter("IP4", iP4) :
                new ObjectParameter("IP4", typeof(int));
    
            var iP5Parameter = iP5 != null ?
                new ObjectParameter("IP5", iP5) :
                new ObjectParameter("IP5", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateEmployeeDetails", iP1Parameter, iP2Parameter, iP3Parameter, iP4Parameter, iP5Parameter);
        }
    }
}
