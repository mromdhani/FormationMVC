namespace ProduitsApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutduchampsQuantiteenstock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produits", "QuantiteEnStock", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produits", "QuantiteEnStock");
        }
    }
}
