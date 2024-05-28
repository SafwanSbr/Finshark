using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class OtherController : ControllerBase
    {
        private readonly IOthersRepository _otherRepo;
        public OtherController(IOthersRepository othersRepo)
        {
            _otherRepo = othersRepo;
        }

        [HttpGet("balanceSheet/{symbol}")]
        public async Task<ActionResult<CompanyBalanceSheet>> GetCompanyBalanceSheet(string symbol)
        {
            var balanceSheet = await _otherRepo.GetCompanyBalanceSheet(symbol);
            if (balanceSheet == null)
            {
                return NotFound();
            }
            return Ok(balanceSheet);
        }

        [HttpGet("cashFlow/{symbol}")]
        public async Task<ActionResult<CompanyCashFlow>> GetCompanyCashFlow(string symbol)
        {
            var cashFlow = await _otherRepo.GetCompanyCashFlow(symbol);
            if (cashFlow == null)
            {
                return NotFound();
            }
            return Ok(cashFlow);
        }

        [HttpGet("incomeStatement/{symbol}")]
        public async Task<ActionResult<CompanyIncomeStatement>> GetCompanyIncomeStatement(string symbol)
        {
            var incomeStatement = await _otherRepo.GetCompanyIncomeStatement(symbol);
            if (incomeStatement == null)
            {
                return NotFound();
            }
            return Ok(incomeStatement);
        }

        [HttpGet("keyMetrics/{symbol}")]
        public async Task<ActionResult<CompanyKeyMetrics>> GetCompanyKeyMetrics(string symbol)
        {
            var keyMetrics = await _otherRepo.GetCompanyKeyMetrics(symbol);
            if (keyMetrics == null)
            {
                return NotFound();
            }
            return Ok(keyMetrics);
        }

        [HttpGet("tenK/{symbol}")]
        public async Task<ActionResult<CompanyTenK>> GetCompanyTenK(string symbol)
        {
            var tenK = await _otherRepo.GetCompanyTenK(symbol);
            if (tenK == null)
            {
                return NotFound();
            }
            return Ok(tenK);
        }
    }
}
