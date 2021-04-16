namespace Microzaym.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TranzStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanTransactions", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoanTransactions", "Status");
        }
    }
}
