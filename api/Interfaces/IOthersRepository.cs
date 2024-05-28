using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IOthersRepository
    {
        Task<CompanyIncomeStatement?> GetCompanyIncomeStatement(string symbol);
        Task<CompanyBalanceSheet?> GetCompanyBalanceSheet(string symbol);
        Task<CompanyCashFlow?> GetCompanyCashFlow(string symbol);
        Task<CompanyKeyMetrics?> GetCompanyKeyMetrics(string symbol);
        Task<CompanyTenK?> GetCompanyTenK(string symbol);
    }
}
