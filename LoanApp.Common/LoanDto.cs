using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Common
{
    public class LoanDto
    {
        public int LoanId { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public int Period { get; set; }
    }
}
