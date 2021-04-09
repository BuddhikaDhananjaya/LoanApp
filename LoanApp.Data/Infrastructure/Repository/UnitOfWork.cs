using LoanApp.Data.Infrastructure.Interfaces;
using LoanApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Data.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LoanAppContext _context;
        private ICustomerRepository _customer;
        private ILoanRepository _loan;

        public UnitOfWork(LoanAppContext context)
        {
            _context = context;
        }

        public ICustomerRepository Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerRepository(_context);
                }

                return _customer;
            }
        }

        public ILoanRepository Loan
        {
            get
            {
                if (_loan == null)
                {
                    _loan = new LoanRepository(_context);
                }

                return _loan;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
