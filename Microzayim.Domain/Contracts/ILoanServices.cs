using Microzayim.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzayim.Domain.Contracts
{
   public interface ILoanServices
    {
        void CreateLoan(LoanModel model);
        IReadOnlyCollection<LoanModel> GetAll();
        LoanModel GetById(int id);
        void UpdateAdmin(LoanModel model);
        void UpdateManager(LoanModel model);
        void UpdateAmountManager(LoanModel model);
    }
}
