using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class OtherRepository: IOthersRepository
    {
        private readonly DataContext _context;
        public OtherRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<CompanyBalanceSheet?> GetCompanyBalanceSheet(string symbol)
        {
            return await _context.companyBalanceSheets.FirstOrDefaultAsync(s => s.Symbol == symbol);
        }

        public async Task<CompanyCashFlow?> GetCompanyCashFlow(string symbol)
        {
            return await _context.companyCashFlows.FirstOrDefaultAsync(s => s.Symbol == symbol);
        }

        public async Task<CompanyIncomeStatement?> GetCompanyIncomeStatement(string symbol)
        {
            return await _context.companyIncomeStatements.FirstOrDefaultAsync(s => s.Symbol == symbol);
        }

        public async Task<CompanyKeyMetrics?> GetCompanyKeyMetrics(string symbol)
        {
            return await _context.companyKeyMetrics.FirstOrDefaultAsync(s => s.Symbol == symbol);
        }

        public async Task<CompanyTenK?> GetCompanyTenK(string symbol)
        {
            return await _context.companyTenKs.FirstOrDefaultAsync(s => s.Symbol == symbol);
        }
    }
}
