﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Server.Models.Entity
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class ExcellonEntities : DbContext
{
    public ExcellonEntities()
        : base("name=ExcellonEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Detail> Details { get; set; }

    public virtual DbSet<Img> Imgs { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Service_> Service_ { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

    public virtual DbSet<Data> Datas { get; set; }

    public virtual DbSet<Vid> Vids { get; set; }


    public virtual ObjectResult<checkAccount_Result> checkAccount(string tableName, string userName, string email, Nullable<int> id)
    {

        var tableNameParameter = tableName != null ?
            new ObjectParameter("tableName", tableName) :
            new ObjectParameter("tableName", typeof(string));


        var userNameParameter = userName != null ?
            new ObjectParameter("userName", userName) :
            new ObjectParameter("userName", typeof(string));


        var emailParameter = email != null ?
            new ObjectParameter("email", email) :
            new ObjectParameter("email", typeof(string));


        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<checkAccount_Result>("checkAccount", tableNameParameter, userNameParameter, emailParameter, idParameter);
    }


    public virtual ObjectResult<getCustomerForDetail_Result> getCustomerForDetail(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCustomerForDetail_Result>("getCustomerForDetail", idParameter);
    }


    public virtual int updateStatus()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateStatus");
    }


    public virtual int updateStatusToFinish(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateStatusToFinish", idParameter);
    }

}

}

