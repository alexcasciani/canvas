﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenLight
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GreenLightEntities : DbContext
    {
        public GreenLightEntities()
            : base("name=GreenLightEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Respons> Responses { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<Neighborhood> Neighborhoods { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<OptionType> OptionTypes { get; set; }
    }
}
