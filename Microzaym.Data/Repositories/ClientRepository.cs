using Microzaym.Data.Contract;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public void CreateLoan(Loan model)
        {
            using (var ctx = new MicrozayimContext())
            {
                model.Status = "Активен";
                model.CreationDate = DateTime.Now;
                ctx.Loans.Add(model);
                ctx.SaveChanges();
            }
        }

        public void CreateTransaction(LoanTransaction model)
        {
            using (var ctx = new MicrozayimContext())
            {
                ctx.LoanTransactions.Add(model);
                ctx.SaveChanges();
            }
        }
    }
}
