using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CompanyIncomeStatement
    {
        [Key]
        public int Id { get; set; } // Assuming a primary key

        [Required]
        public string Date { get; set; }

        [Required]
        public string Symbol { get; set; }

        [Required]
        public string ReportedCurrency { get; set; }

        [Required]
        public string CIK { get; set; }

        [Required]
        public string FillingDate { get; set; }

        [Required]
        public string AcceptedDate { get; set; }

        [Required]
        public string CalendarYear { get; set; }

        [Required]
        public string Period { get; set; }

        [Required]
        public decimal Revenue { get; set; }

        [Required]
        public decimal CostOfRevenue { get; set; }

        [Required]
        public decimal GrossProfit { get; set; }

        [Required]
        public decimal GrossProfitRatio { get; set; }

        public decimal? ResearchAndDevelopmentExpenses { get; set; }

        public decimal? GeneralAndAdministrativeExpenses { get; set; }

        public decimal? SellingAndMarketingExpenses { get; set; }

        public decimal? SellingGeneralAndAdministrativeExpenses { get; set; }

        public decimal? OtherExpenses { get; set; }

        [Required]
        public decimal OperatingExpenses { get; set; }

        [Required]
        public decimal CostAndExpenses { get; set; }

        public decimal? InterestIncome { get; set; }

        public decimal? InterestExpense { get; set; }

        public decimal? DepreciationAndAmortization { get; set; }

        [Required]
        public decimal EBITDA { get; set; }

        [Required]
        public decimal EBITDARatio { get; set; }

        [Required]
        public decimal OperatingIncome { get; set; }

        [Required]
        public decimal OperatingIncomeRatio { get; set; }

        [Required]
        public decimal TotalOtherIncomeExpensesNet { get; set; }

        [Required]
        public decimal IncomeBeforeTax { get; set; }

        [Required]
        public decimal IncomeBeforeTaxRatio { get; set; }

        [Required]
        public decimal IncomeTaxExpense { get; set; }

        [Required]
        public decimal NetIncome { get; set; }

        [Required]
        public decimal NetIncomeRatio { get; set; }

        [Required]
        public decimal EPS { get; set; }

        [Required]
        public decimal EPSDiluted { get; set; }

        [Required]
        public decimal WeightedAverageShsOut { get; set; }

        [Required]
        public decimal WeightedAverageShsOutDil { get; set; }

        public string Link { get; set; }

        public string FinalLink { get; set; }
    }
}
