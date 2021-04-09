using LoanApp.Bll.Service.Interface;
using LoanApp.Common;
using LoanApp.Data.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Bll.Service
{
    public class LoanService : ILoanService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool RequestLoan(LoanInfoDto loanInfoDto)
        {
            CustomerDto customerDto = new CustomerDto()
            {
                CustomerName = loanInfoDto.CustomerName,
                Age = loanInfoDto.Age,
                Nic = loanInfoDto.Nic
            };

            _unitOfWork.Customer.Add(customerDto);

            LoanDto loanDto = new LoanDto()
            {
                Amount = loanInfoDto.Amount,
                Period = loanInfoDto.Period,
                Rate = loanInfoDto.Rate
            };

            _unitOfWork.Loan.Add(loanDto);

            return true;
        }

        public bool SaveCustomer(CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }
    }
}
