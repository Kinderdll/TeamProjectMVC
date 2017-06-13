namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImgAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImgPath");
        }
    }
}
