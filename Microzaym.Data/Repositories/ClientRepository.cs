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
    public class ClientRepository : IClientRepository
    {
        private readonly IManagerRepository _managerRepository;

        private readonly IAdminRepository _adminRepository;
        public ClientRepository(IManagerRepository managerRepository, IAdminRepository adminRepository)
        {
            _managerRepository = managerRepository;
            _adminRepository = adminRepository;
        }

        public void CreateLoan(Loan model)
        {
            using (var ctx = new MicrozayimContext())
            {
                ctx.Loans.Add(model);
                ctx.SaveChanges();
            }
        }
        public Loan GetById(int id)
        {
            using (var ctx = new MicrozayimContext())
            {
                return ctx.Loans.Include(x => x.LoanTransactions)
                          .FirstOrDefault(x => x.Id == id);
            }
        }
        public LoanTransaction GetByIdTr(int id)
        {
            using (var ctx = new MicrozayimContext())
            {
                return ctx.LoanTransactions
                          .FirstOrDefault(x => x.LoansId == id);
            }
        }

        public void CreateTransaction(LoanTransaction model)
        {
            using (var ctx = new MicrozayimContext())
            {
               
                //model.Loans = _adminRepository.GetById(model.LoansId);

                ctx.LoanTransactions.Add(model);
                ctx.SaveChanges();
            }
        }
    }
}
