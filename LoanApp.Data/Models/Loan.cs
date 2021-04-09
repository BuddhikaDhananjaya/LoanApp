using System;
using System.Collections.Generic;

#nullable disable

namespace LoanApp.Data.Models
{
    public partial class Loan
    {
        public int LoanId { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal Rate { get; set; }
        public int Period { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
