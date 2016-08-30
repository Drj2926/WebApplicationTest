﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEnvironment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestDevEntities : DbContext
    {
        public TestDevEntities()
            : base("name=TestDevEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<WhitegloveDetails_Test> WhitegloveDetails_Test { get; set; }
    
        public virtual ObjectResult<sp_GetAccountIDSummary_Result> sp_GetAccountIDSummary()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAccountIDSummary_Result>("sp_GetAccountIDSummary");
        }
    
        public virtual ObjectResult<sp_getCustomerIDInfo_Result> sp_getCustomerIDInfo(string accountID)
        {
            var accountIDParameter = accountID != null ?
                new ObjectParameter("accountID", accountID) :
                new ObjectParameter("accountID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getCustomerIDInfo_Result>("sp_getCustomerIDInfo", accountIDParameter);
        }
    
        public virtual ObjectResult<string> sp_AutoComplete_Get_Customer(string searchText)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("searchText", searchText) :
                new ObjectParameter("searchText", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_AutoComplete_Get_Customer", searchTextParameter);
        }
    }
}
