using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Models
{
   public class Loan
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public string Status { get; set; }
        public int Amount { get; set; }

        public string CustomerId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<LoanTransaction> LoanTransactions { get; set; }
    }
}
