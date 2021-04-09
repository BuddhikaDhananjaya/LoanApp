using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Data.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customer { get; }
        ILoanRepository Loan { get; }
        void Save();
    }
}
