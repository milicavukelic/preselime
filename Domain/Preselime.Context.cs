﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class preselimeEntities : DbContext
    {
        public preselimeEntities()
            : base("name=preselimeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipMoveType> ShipMoveTypes { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TransportType> TransportTypes { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
