﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MUSIC_STOREEntities : DbContext
    {
        public MUSIC_STOREEntities()
            : base("name=MUSIC_STOREEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Composer> Composers { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Order_Album> Order_Album { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Singer> Singers { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
    }
}
