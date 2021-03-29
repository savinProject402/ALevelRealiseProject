using Microzaym.Data.Contract;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        public void UpdateAmountManager(Loan model)
        {
            using (var ctx = new MicrozayimContext())
            {
                var upAmount = ctx.Loans.First(x => x.CustomerId == x.CustomerId);
                upAmount.Amount = model.Amount;
                ctx.SaveChanges();
            }
        }

        public void UpdateManager(Loan model)
        {
            using (var ctx = new MicrozayimContext())
            {
                var upManager = ctx.Loans.First(x => x.CustomerId == x.CustomerId);

                upManager.Status = model.Status;
                ctx.SaveChanges();
            }
        }
    }
}
