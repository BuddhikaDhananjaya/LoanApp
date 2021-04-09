using System;
using System.Collections.Generic;

#nullable disable

namespace LoanApp.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Loans = new HashSet<Loan>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Nic { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }
    }
}
