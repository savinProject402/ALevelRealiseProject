﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Models
{
   public class Loans
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public string Status { get; set; }
        public int Amount { get; set; }

        public string CustomerId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
