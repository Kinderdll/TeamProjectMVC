namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductstoList : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Product_ProductID" });
            DropColumn("dbo.Products", "Username");
            DropColumn("dbo.Products", "Product_ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Product_ProductID", c => c.Int());
            AddColumn("dbo.Products", "Username", c => c.String());
            CreateIndex("dbo.Products", "Product_ProductID");
            AddForeignKey("dbo.Products", "Product_ProductID", "dbo.Products", "ProductID");
        }
    }
}
