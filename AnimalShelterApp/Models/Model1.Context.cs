﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimalShelterApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Animal_ShelterEntities : DbContext
    {
        public Animal_ShelterEntities()
            : base("name=Animal_ShelterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adoption> Adoptions { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
    }
}
