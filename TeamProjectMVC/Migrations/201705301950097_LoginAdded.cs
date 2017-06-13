namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoginAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "TaxRegNumber", c => c.String());
            DropColumn("dbo.Users", "TRN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "TRN", c => c.String());
            DropColumn("dbo.Users", "TaxRegNumber");
        }
    }
}
