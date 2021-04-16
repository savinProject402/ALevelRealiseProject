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
        private readonly IManagerRepository _managerRepository;

        public ClientRepository(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

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
                model.CreationDate = DateTime.Now;
                model.Status = 0;
                ctx.LoanTransactions.Add(model);
                ctx.SaveChanges();
            }
            //_managerRepository.UpdateAmountManagers();
        }
    }
}
