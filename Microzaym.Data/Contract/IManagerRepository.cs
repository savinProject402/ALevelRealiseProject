using Microzaym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Contract
{
   public interface IManagerRepository
    {
        void UpdateManager(Loan model);         //Update Status Accepted by Manader
        void UpdateAmountManager(Loan model);   //Update Status Closed by Manader  //Списан
    }
}
