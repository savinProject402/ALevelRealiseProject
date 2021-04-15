using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzayim.Domain.Models
{
   public class LoanTransactionModel
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int Amount { get; set; }
        public int LoansId { get; set; }
    }
}
