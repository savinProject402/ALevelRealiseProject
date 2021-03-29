using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microzaym.Data.Models
{
   public class ApplicationUser : IdentityUser
    {
        public ICollection<Loan> Loans { get; set; }
        public ICollection<UsersNetwork> Networks { get; set; }
    }
}
