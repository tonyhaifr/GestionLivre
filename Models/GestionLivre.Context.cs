﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Gestion_LivreEntities : DbContext
    {
        public Gestion_LivreEntities()
            : base("name=Gestion_LivreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auteur> Auteur { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<DetailCommande> DetailCommande { get; set; }
        public virtual DbSet<Edition> Edition { get; set; }
        public virtual DbSet<Livre> Livre { get; set; }
        public virtual DbSet<Participer> Participer { get; set; }
        public virtual DbSet<Sujet> Sujet { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
