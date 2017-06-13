namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SignUp_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Category", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "CompanyName", c => c.String());
            AddColumn("dbo.Users", "TaxOffice", c => c.String());
            AddColumn("dbo.Users", "TRN", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "TRN");
            DropColumn("dbo.Users", "TaxOffice");
            DropColumn("dbo.Users", "CompanyName");
            DropColumn("dbo.Users", "Category");
            DropColumn("dbo.Users", "Password");
        }
    }
}
