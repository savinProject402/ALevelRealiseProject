using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Contract
{
   public interface IClientRepository
    {
        void CreateLoan(Loan model); // Client Create Credit 
        void CreateTransaction(LoanTransaction model); // Client Create Tranzactions for Repayment
    }
}
