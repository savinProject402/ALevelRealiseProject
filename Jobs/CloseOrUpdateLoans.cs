using Microzaym.Data;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevelRealiseProject.Jobs
{
    public class CloseOrUpdateLoans
    {
        public  IReadOnlyCollection<LoanTransaction> GetAllTranzaction()
        {
            using (var ctx = new MicrozayimContext())
            {

                var result = ctx.LoanTransactions.AsNoTracking().ToList();
                return result;
                //if (allTranz.LoansId == allLoans.Id && allTranz.Amount == allLoans.Amount)
                //{
                //    ctx.Loans.Add(Loan.Status = "Закрыт");
                //    ctx.Loans.Add(model);
                //    ctx.SaveChanges();
                //}
                //else
                //{
                //    model.Amount = allTranz.Amount - allLoans.Amount;
                //    ctx.Loans.Add(model);
                //    ctx.SaveChanges();
                //}

            }

        }
        public IEnumerable<Loan> UpdateLoansAfterTranzaction()
        {
            using (var ctx = new MicrozayimContext())
            {
                var result = ctx.Loans.AsNoTracking().ToList().Where(x => x.Status == "Активен");
                var q = GetAllTranzaction();
                var loans = ctx.Loans.Join(ctx.LoanTransactions, l => l.Id, lt => lt.LoansId, (l, lt) => new
                {
                    sum = lt.Amount,
                    t = l.Amount
                });
                foreach (var u in loans)
                {
                };
                ctx.SaveChanges();

                return result;
            }
        }
    }
}