using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Models
{
    public class LoanTransaction
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }
        public int Status { get; set; }

        public int Amount { get; set; }

        public int LoansId { get; set; }
        public Loan Loan { get; set; }

    }
}
