using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Common
{
    public class LoanInfoDto
    {
        public int LoanId { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public int Period { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Nic { get; set; }
    }
}
