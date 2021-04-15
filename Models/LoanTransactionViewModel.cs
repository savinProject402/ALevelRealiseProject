using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevelRealiseProject.Models
{
    public class LoanTransactionViewModel
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int Amount { get; set; }
        public int LoansId { get; set; }
    }
}