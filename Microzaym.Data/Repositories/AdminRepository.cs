using Microzaym.Data.Contract;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Microzaym.Data.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public IReadOnlyCollection<Loan> GetAll()
        {
            using (var ctx = new MicrozayimContext())
            {
                return ctx.Loans
                    .AsNoTracking()
                    .ToList();
            }
        }

        public Loan GetById(int id)
        {
            using (var ctx = new MicrozayimContext())
            {
                return ctx.Loans.Include(x=>x.LoanTransactions)
                          .FirstOrDefault(x => x.Id == id);
            }
        }

        public void UpdateAdmin(Loan model)
        {
            using (var ctx = new MicrozayimContext())
            {
                var upAdmin = ctx.Loans.FirstOrDefault(x => x.Id == model.Id);

                upAdmin.Status = model.Status;
                ctx.SaveChanges();
            }
        }
    }
}
