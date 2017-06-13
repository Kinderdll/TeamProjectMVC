namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CombinedModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Username", c => c.String());
            AddColumn("dbo.Products", "Product_ProductID", c => c.Int());
            AddColumn("dbo.Products", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Products", "Product_ProductID");
            CreateIndex("dbo.Products", "Category_CategoryID");
            AddForeignKey("dbo.Products", "Product_ProductID", "dbo.Products", "ProductID");
            AddForeignKey("dbo.Products", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Category_CategoryID" });
            DropIndex("dbo.Products", new[] { "Product_ProductID" });
            DropColumn("dbo.Products", "Category_CategoryID");
            DropColumn("dbo.Products", "Product_ProductID");
            DropColumn("dbo.Products", "Username");
        }
    }
}
