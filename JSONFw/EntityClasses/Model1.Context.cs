﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JSONFw.EntityClasses
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jinsasan2db : DbContext
    {
        public jinsasan2db()
            : base("name=jinsasan2db")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Apasara> Apasaras { get; set; }
        public virtual DbSet<Bhojanshala> Bhojanshalas { get; set; }
        public virtual DbSet<CityMaster> CityMasters { get; set; }
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Dharmshala> Dharmshalas { get; set; }
        public virtual DbSet<IdolMaster> IdolMasters { get; set; }
        public virtual DbSet<IdolType> IdolTypes { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TempleIdolMapping> TempleIdolMappings { get; set; }
        public virtual DbSet<TempleTable> TempleTables { get; set; }
        public virtual DbSet<TrustMaster> TrustMasters { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<EntryRequest> EntryRequests { get; set; }
    }
}