﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BP2_PR6_2017
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelProjContainer : DbContext
    {
        public ModelProjContainer()
            : base("name=ModelProjContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Nagrada> NagradaSet { get; set; }
        public virtual DbSet<Izdavac> IzdavacSet { get; set; }
        public virtual DbSet<Autor> AutorSet { get; set; }
        public virtual DbSet<Skladiste> SkladisteSet { get; set; }
        public virtual DbSet<Korisnik> KorisnikSet { get; set; }
        public virtual DbSet<Recenzija> RecenzijaSet { get; set; }
        public virtual DbSet<Knjiga> KnjigaSet { get; set; }
        public virtual DbSet<Nalazi> NalaziSet { get; set; }
        public virtual DbSet<Osvaja> OsvajaSet { get; set; }
        public virtual DbSet<Kreira> KreiraSet { get; set; }
        public virtual DbSet<Kupovina> KupovinaSet { get; set; }
    }
}
