using Microzayim.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzayim.Domain.Contracts
{
   public interface ILoanTransactionServices
    {
        void CreateTransaction(LoanTransactionModel model);

    }
}
