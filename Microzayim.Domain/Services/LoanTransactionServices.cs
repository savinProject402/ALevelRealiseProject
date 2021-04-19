using AutoMapper;
using Microzayim.Domain.Contracts;
using Microzayim.Domain.Models;
using Microzaym.Data.Contract;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzayim.Domain.Services
{
    public class LoanTransactionServices : ILoanTransactionServices
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public LoanTransactionServices(IMapper mapper, IClientRepository clientRepository, IAdminRepository adminRepository)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
            _adminRepository = adminRepository;
        }
        public void CreateTransaction(LoanTransactionModel model)
        {
            var createTransaction = _mapper.Map<LoanTransaction>(model);


            _clientRepository.CreateTransaction(createTransaction);

            var loan = _adminRepository.GetById(createTransaction.LoansId);
            loan.LoanTransactions = createTransaction.Loans.LoanTransactions;
            //loan.LoansTransactions.Where(i => i.Status == 0).Sum(i => i.Amount);


            if (loan.LoanTransactions.Sum(x => x.Amount) >= createTransaction.Amount)
            {
                loan.Status = "Close";
                _adminRepository.UpdateAdmin(loan);
            }

        }
    }
}
