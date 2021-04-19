namespace Microzaym.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Real : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans");
            AddForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans");
            AddForeignKey("dbo.LoanTransactions", "LoansId", "dbo.Loans", "Id", cascadeDelete: true);
        }
    }
}
