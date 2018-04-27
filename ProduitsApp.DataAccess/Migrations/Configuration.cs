namespace ProduitsApp.DataAccess.Migrations
{
    using ProduitsApp.DataAccess.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProduitsApp.DataAccess.Infrastructure.ProduitsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProduitsApp.DataAccess.Infrastructure.ProduitsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Produits.AddOrUpdate(new Produit {Id="P100", Libelle="Cafe", PrixUnitaire=100M });
            context.Produits.AddOrUpdate(new Produit { Id = "P200", Libelle = "Thé", PrixUnitaire = 200M });
            context.Produits.AddOrUpdate(new Produit { Id = "P300", Libelle = "Jus d'orange", PrixUnitaire = 300M });
        }
    }
}
