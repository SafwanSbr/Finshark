using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IOthersRepository
    {
        Task<List<CompanyIncomeStatement>> GetCompanyIncomeStatement(string symbol);
        Task<List<CompanyBalanceSheet>> GetCompanyBalanceSheet(string symbol);
        Task<List<CompanyCashFlow>> GetCompanyCashFlow(string symbol);
        Task<List<CompanyKeyMetrics>> GetCompanyKeyMetrics(string symbol);
        Task<List<CompanyTenK>> GetCompanyTenK(string symbol);
    }
}
