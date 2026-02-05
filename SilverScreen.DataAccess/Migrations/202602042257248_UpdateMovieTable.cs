namespace SilverScreen.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.Movies", "Type", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Type", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(maxLength: 20));
        }
    }
}
