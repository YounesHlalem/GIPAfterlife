﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class AfterlifeDataBaseEntities : DbContext
{
    public AfterlifeDataBaseEntities()
        : base("name=AfterlifeDataBaseEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Afdeling> Afdelings { get; set; }
    public virtual DbSet<Bestelling> Bestellings { get; set; }
    public virtual DbSet<Zoeker> Zoekers { get; set; }
    public virtual DbSet<Userinformation> Userinformations { get; set; }
    public virtual DbSet<Gastenboek> Gastenboeks { get; set; }
    public virtual DbSet<Contact> Contacts { get; set; }
    public virtual DbSet<Plaatsing> Plaatsings { get; set; }
}
