namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CombinedModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "TRN", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "TaxRegNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "TaxRegNumber", c => c.String());
            DropColumn("dbo.Users", "TRN");
        }
    }
}
