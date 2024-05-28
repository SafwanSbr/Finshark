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

        public async Task<List<CompanyBalanceSheet>> GetCompanyBalanceSheet(string symbol)
        {
            return await _context.companyBalanceSheets.Where(s => s.Symbol == symbol).ToListAsync();
        }

        public async Task<List<CompanyCashFlow>> GetCompanyCashFlow(string symbol)
        {
            return await _context.companyCashFlows.Where(s => s.Symbol == symbol).ToListAsync();
        }

        public async Task<List<CompanyIncomeStatement>> GetCompanyIncomeStatement(string symbol)
        {
            return await _context.companyIncomeStatements.Where(s => s.Symbol == symbol).ToListAsync();
        }

        public async Task<List<CompanyKeyMetrics>> GetCompanyKeyMetrics(string symbol)
        {
            return await _context.companyKeyMetrics.Where(s => s.Symbol == symbol).ToListAsync();
        }

        public async Task<List<CompanyTenK>> GetCompanyTenK(string symbol)
        {
            return await _context.companyTenKs.Where(s => s.Symbol == symbol).ToListAsync();
        }

    }
}
