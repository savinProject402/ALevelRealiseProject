using AutoMapper;
using Microzayim.Domain.Contracts;
using Microzayim.Domain.Models;
using Microzaym.Data;
using Microzaym.Data.Contract;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzayim.Domain.Services
{
    public class LoanServices : ILoanServices
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IManagerRepository _managerRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public LoanServices(IMapper mapper, IClientRepository clientRepository, IManagerRepository managerRepository, IAdminRepository adminRepository)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
            _managerRepository = managerRepository;
            _adminRepository = adminRepository;
        }



        public void CreateLoan(LoanModel model) 
        {
            var createLoan = _mapper.Map<Loan>(model);
            model.Status = "Active";
            model.CreationDate = DateTime.Now;


            var custLoans = _adminRepository.GetAll()
                .Where(x => model.Status == "Активен" && x.CustomerId == model.CustomerId);

            if (custLoans.Count() > 2)
            {
                throw new Exception("Brother you have MAX Count Loans");
            }

            _clientRepository.CreateLoan(createLoan);
        }

        public IReadOnlyCollection<LoanModel> GetAll()
        {
            var loan = _adminRepository.GetAll();
            var result = _mapper.Map<IReadOnlyCollection<LoanModel>>(loan);

            return result;
        }

        public LoanModel GetById(int id)
        {
            var adminGetById = _adminRepository.GetById(id);
            var result = _mapper.Map<LoanModel>(adminGetById);

            return result;
        }

        public void UpdateAdmin(LoanModel model)
        {
            var adminUpdate = _mapper.Map<Loan>(model);
            _adminRepository.UpdateAdmin(adminUpdate);
        }

        public void UpdateAmountManager(LoanModel model) //как списание
        {
            var managerUpdate = _mapper.Map<Loan>(model);
            _managerRepository.UpdateAmountManager(managerUpdate);
        }

        public void UpdateManager(LoanModel model) //принять
        {
            var managerUpdate = _mapper.Map<Loan>(model);
            _managerRepository.UpdateAmountManager(managerUpdate);
        }
    }
}
