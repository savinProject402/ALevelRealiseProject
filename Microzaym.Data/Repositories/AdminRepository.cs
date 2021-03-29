using Microzaym.Data.Contract;
using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public IReadOnlyCollection<Loan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Loan GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdmin(Loan model)
        {
            throw new NotImplementedException();
        }
    }
}
