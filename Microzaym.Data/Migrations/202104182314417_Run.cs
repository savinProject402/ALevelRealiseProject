namespace Microzaym.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Run : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans");
            DropIndex("dbo.LoanTransactions", new[] { "LoansId" });
            AlterColumn("dbo.LoanTransactions", "LoansId", c => c.Int(nullable: false));
            CreateIndex("dbo.LoanTransactions", "LoansId");
            AddForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans");
            DropIndex("dbo.LoanTransactions", new[] { "LoansId" });
            AlterColumn("dbo.LoanTransactions", "LoansId", c => c.Int());
            CreateIndex("dbo.LoanTransactions", "LoansId");
            AddForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans", "Id");
        }
    }
}
