namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class review : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        Rate = c.Byte(nullable: false),
                        UserID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "UserID", "dbo.Users");
            DropForeignKey("dbo.Reviews", "ProductID", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "ProductID" });
            DropIndex("dbo.Reviews", new[] { "UserID" });
            DropTable("dbo.Reviews");
        }
    }
}
