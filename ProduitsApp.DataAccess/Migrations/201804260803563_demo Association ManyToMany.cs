namespace ProduitsApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demoAssociationManyToMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livreurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LivreurProduits",
                c => new
                    {
                        Livreur_Id = c.Int(nullable: false),
                        Produit_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Livreur_Id, t.Produit_Id })
                .ForeignKey("dbo.Livreurs", t => t.Livreur_Id, cascadeDelete: true)
                .ForeignKey("dbo.Produits", t => t.Produit_Id, cascadeDelete: true)
                .Index(t => t.Livreur_Id)
                .Index(t => t.Produit_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LivreurProduits", "Produit_Id", "dbo.Produits");
            DropForeignKey("dbo.LivreurProduits", "Livreur_Id", "dbo.Livreurs");
            DropIndex("dbo.LivreurProduits", new[] { "Produit_Id" });
            DropIndex("dbo.LivreurProduits", new[] { "Livreur_Id" });
            DropTable("dbo.LivreurProduits");
            DropTable("dbo.Livreurs");
        }
    }
}
