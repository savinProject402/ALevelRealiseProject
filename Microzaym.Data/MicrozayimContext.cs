using Microsoft.AspNet.Identity.EntityFramework;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data
{
    public class MicrozayimContext : IdentityDbContext<IdentityUser>
    {
        public MicrozayimContext() : base("DefaultConnection") { }

        public DbSet<Loan> Loans { get; set; }
        public DbSet<UsersNetwork> UsersNetworks { get; set; }
        public DbSet<LoanTransaction> LoanTransactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Loan>()
                        .HasOptional(x => x.User)
                        .WithMany(x => x.Loans)
                        .HasForeignKey(x => x.CustomerId);

            modelBuilder.Entity<LoanTransaction>()
                        .HasRequired(x => x.Loan)
                        .WithMany(x => x.LoansTransactions)
                        .HasForeignKey(x => x.LoansId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<UsersNetwork>()
            .HasRequired(x => x.Owner)
            .WithMany(x => x.Networks)
            .HasForeignKey(x => x.OwnerId);


        }
    }
}
