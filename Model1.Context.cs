﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AXCH
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AXCHEntities : DbContext
    {
        public AXCHEntities()
            : base("name=AXCHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Devisions> Devisions { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<MaterialValues> MaterialValues { get; set; }
        public virtual DbSet<MaterialValuesAccounting> MaterialValuesAccounting { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
    }
}