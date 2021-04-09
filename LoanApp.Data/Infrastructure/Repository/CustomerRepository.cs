using LoanApp.Common;
using LoanApp.Data.Infrastructure.Interfaces;
using LoanApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Data.Infrastructure.Repository
{
    public class CustomerRepository : Repository<CustomerDto>, ICustomerRepository
    {
        public CustomerRepository(LoanAppContext Context) : base(Context) { }
    }
}
