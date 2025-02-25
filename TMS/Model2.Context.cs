﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SumShippReportTmsDbEntities : DbContext
    {
        public SumShippReportTmsDbEntities()
            : base("name=SumShippReportTmsDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetSumShippReport_Result> GetSumShippReport(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, string customerNum, string fromEmployee, string toEmployee)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var customerNumParameter = customerNum != null ?
                new ObjectParameter("CustomerNum", customerNum) :
                new ObjectParameter("CustomerNum", typeof(string));
    
            var fromEmployeeParameter = fromEmployee != null ?
                new ObjectParameter("FromEmployee", fromEmployee) :
                new ObjectParameter("FromEmployee", typeof(string));
    
            var toEmployeeParameter = toEmployee != null ?
                new ObjectParameter("ToEmployee", toEmployee) :
                new ObjectParameter("ToEmployee", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSumShippReport_Result>("GetSumShippReport", fromDateParameter, toDateParameter, customerNumParameter, fromEmployeeParameter, toEmployeeParameter);
        }
    }
}
