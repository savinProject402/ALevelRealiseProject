namespace Microzaym.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tranz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoanTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        LoansId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Loans", t => t.LoansId)
                .Index(t => t.LoansId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans");
            DropIndex("dbo.LoanTransactions", new[] { "LoansId" });
            DropTable("dbo.LoanTransactions");
        }
    }
}
