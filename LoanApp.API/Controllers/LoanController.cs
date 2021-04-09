using LoanApp.Bll.Service;
using LoanApp.Bll.Service.Interface;
using LoanApp.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService loanService;

        public LoanController(ILoanService loanService)
        {
            this.loanService = loanService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index([FromBody] CustomerDto model)
        {
            //return View();
            return Ok("Register");
        }

        [HttpPost]
        public IActionResult ProcessLoan([FromBody] LoanInfoDto loanInfoDto)
        {
            bool loanStatus = loanService.RequestLoan(loanInfoDto);


            //CustomerDto customerDto = new CustomerDto()
            //{
            //    CustomerName = loanInfoDto.CustomerName,
            //    Age = loanInfoDto.Age,
            //    Nic = loanInfoDto.Nic
            //};

            //LoanDto loanDto = new LoanDto()
            //{
            //    Amount = loanInfoDto.Amount,
            //    Period = loanInfoDto.Period,
            //    Rate = loanInfoDto.Rate                
            //};

            //bool customerStatus = loanService.SaveCustomer(customerDto);
            //bool loanStatus = loanService.RequestLoan(loanDto);

            if (loanStatus)
            {
                return Ok();
            }

            return BadRequest("Error");
        }
    }
}
