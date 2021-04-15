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
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public LoanTransactionServices(IMapper mapper, IClientRepository clientRepository)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
        }

        public void CreateTransaction(LoanTransactionModel model)
        {
            var createTransaction = _mapper.Map<LoanTransaction>(model);
            _clientRepository.CreateTransaction(createTransaction);
        }
    }
}
