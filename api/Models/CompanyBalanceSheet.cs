using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CompanyBalanceSheet
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
        public decimal CashAndCashEquivalents { get; set; }

        [Required]
        public decimal ShortTermInvestments { get; set; }

        [Required]
        public decimal CashAndShortTermInvestments { get; set; }

        [Required]
        public decimal NetReceivables { get; set; }

        [Required]
        public decimal Inventory { get; set; }

        [Required]
        public decimal OtherCurrentAssets { get; set; }

        [Required]
        public decimal TotalCurrentAssets { get; set; }

        [Required]
        public decimal PropertyPlantEquipmentNet { get; set; }

        public decimal? Goodwill { get; set; }

        public decimal? IntangibleAssets { get; set; }

        public decimal? GoodwillAndIntangibleAssets { get; set; }

        public decimal? LongTermInvestments { get; set; }

        public decimal? TaxAssets { get; set; }

        public decimal? OtherNonCurrentAssets { get; set; }

        [Required]
        public decimal TotalNonCurrentAssets { get; set; }

        public decimal? OtherAssets { get; set; }

        [Required]
        public decimal TotalAssets { get; set; }

        [Required]
        public decimal AccountPayables { get; set; }

        [Required]
        public decimal ShortTermDebt { get; set; }

        [Required]
        public decimal TaxPayables { get; set; }

        public decimal? DeferredRevenue { get; set; }

        public decimal? OtherCurrentLiabilities { get; set; }

        [Required]
        public decimal TotalCurrentLiabilities { get; set; }

        [Required]
        public decimal LongTermDebt { get; set; }

        public decimal? DeferredRevenueNonCurrent { get; set; }

        public decimal? DeferredTaxLiabilitiesNonCurrent { get; set; }

        public decimal? OtherNonCurrentLiabilities { get; set; }

        [Required]
        public decimal TotalNonCurrentLiabilities { get; set; }

        public decimal? OtherLiabilities { get; set; }

        public decimal? CapitalLeaseObligations { get; set; }

        [Required]
        public decimal TotalLiabilities { get; set; }

        public decimal? PreferredStock { get; set; }

        [Required]
        public decimal CommonStock { get; set; }

        [Required]
        public decimal RetainedEarnings { get; set; }

        public decimal? AccumulatedOtherComprehensiveIncomeLoss { get; set; }

        public decimal? OtherTotalStockholdersEquity { get; set; }

        [Required]
        public decimal TotalStockholdersEquity { get; set; }

        [Required]
        public decimal TotalEquity { get; set; }

        [Required]
        public decimal TotalLiabilitiesAndStockholdersEquity { get; set; }

        public decimal? MinorityInterest { get; set; }

        [Required]
        public decimal TotalLiabilitiesAndTotalEquity { get; set; }

        [Required]
        public decimal TotalInvestments { get; set; }

        [Required]
        public decimal TotalDebt { get; set; }

        [Required]
        public decimal NetDebt { get; set; }

        public string Link { get; set; }

        public string FinalLink { get; set; }
    }
}
