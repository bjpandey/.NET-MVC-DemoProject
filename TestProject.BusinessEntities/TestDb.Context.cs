﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProject.BusinessEntities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestDBEntities : DbContext
    {
        public TestDBEntities()
            : base("name=TestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual int SpUserIns(string userName, ObjectParameter returnMessage)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpUserIns", userNameParameter, returnMessage);
        }
    
        public virtual ObjectResult<SpUserSel_Result> SpUserSel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpUserSel_Result>("SpUserSel");
        }
    
        public virtual ObjectResult<SpUserSelById_Result> SpUserSelById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpUserSelById_Result>("SpUserSelById", idParameter);
        }
    
        public virtual int SpUserUpd(Nullable<int> id, string userName, ObjectParameter returnMessage)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpUserUpd", idParameter, userNameParameter, returnMessage);
        }
    
        public virtual int SpOrderDel(Nullable<int> id, ObjectParameter returnMessage)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpOrderDel", idParameter, returnMessage);
        }
    
        public virtual int SpOrderIns(Nullable<int> userId, string supplyName, Nullable<decimal> unitCost, Nullable<decimal> unitPrice, Nullable<decimal> markup, Nullable<int> qty, Nullable<decimal> totalPrice, ObjectParameter returnMessage)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var supplyNameParameter = supplyName != null ?
                new ObjectParameter("SupplyName", supplyName) :
                new ObjectParameter("SupplyName", typeof(string));
    
            var unitCostParameter = unitCost.HasValue ?
                new ObjectParameter("UnitCost", unitCost) :
                new ObjectParameter("UnitCost", typeof(decimal));
    
            var unitPriceParameter = unitPrice.HasValue ?
                new ObjectParameter("UnitPrice", unitPrice) :
                new ObjectParameter("UnitPrice", typeof(decimal));
    
            var markupParameter = markup.HasValue ?
                new ObjectParameter("Markup", markup) :
                new ObjectParameter("Markup", typeof(decimal));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("Qty", qty) :
                new ObjectParameter("Qty", typeof(int));
    
            var totalPriceParameter = totalPrice.HasValue ?
                new ObjectParameter("TotalPrice", totalPrice) :
                new ObjectParameter("TotalPrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpOrderIns", userIdParameter, supplyNameParameter, unitCostParameter, unitPriceParameter, markupParameter, qtyParameter, totalPriceParameter, returnMessage);
        }
    
        public virtual ObjectResult<SpOrderSelbyId_Result> SpOrderSelbyId(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrderSelbyId_Result>("SpOrderSelbyId", idParameter);
        }
    
        public virtual int SpOrderUpd(Nullable<int> id, Nullable<int> userId, string supplyName, Nullable<decimal> unitCost, Nullable<decimal> unitPrice, Nullable<decimal> markup, Nullable<int> qty, Nullable<decimal> totalPrice, ObjectParameter returnMessage)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var supplyNameParameter = supplyName != null ?
                new ObjectParameter("SupplyName", supplyName) :
                new ObjectParameter("SupplyName", typeof(string));
    
            var unitCostParameter = unitCost.HasValue ?
                new ObjectParameter("UnitCost", unitCost) :
                new ObjectParameter("UnitCost", typeof(decimal));
    
            var unitPriceParameter = unitPrice.HasValue ?
                new ObjectParameter("UnitPrice", unitPrice) :
                new ObjectParameter("UnitPrice", typeof(decimal));
    
            var markupParameter = markup.HasValue ?
                new ObjectParameter("Markup", markup) :
                new ObjectParameter("Markup", typeof(decimal));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("Qty", qty) :
                new ObjectParameter("Qty", typeof(int));
    
            var totalPriceParameter = totalPrice.HasValue ?
                new ObjectParameter("TotalPrice", totalPrice) :
                new ObjectParameter("TotalPrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpOrderUpd", idParameter, userIdParameter, supplyNameParameter, unitCostParameter, unitPriceParameter, markupParameter, qtyParameter, totalPriceParameter, returnMessage);
        }
    
        public virtual ObjectResult<SpDropDownlistForUsersel_Result> SpDropDownlistForUsersel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpDropDownlistForUsersel_Result>("SpDropDownlistForUsersel");
        }
    
        public virtual ObjectResult<SpOrderSel_Result> SpOrderSel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrderSel_Result>("SpOrderSel");
        }
    
        public virtual int SpUserDel(Nullable<int> id, ObjectParameter returnMessage)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpUserDel", idParameter, returnMessage);
        }
    }
}