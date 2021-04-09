using LoanApp.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Bll.Service.Interface
{
    public interface ILoanService
    {
        bool RequestLoan(LoanInfoDto loanInfoDto);
        bool SaveCustomer(CustomerDto customerDto);        
    }
}
