using System.ComponentModel.DataAnnotations;

namespace api.Models
{

    public class CompanyCashFlow
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
        public decimal NetIncome { get; set; }

        [Required]
        public decimal DepreciationAndAmortization { get; set; }

        public decimal? DeferredIncomeTax { get; set; }

        public decimal? StockBasedCompensation { get; set; }

        public decimal? ChangeInWorkingCapital { get; set; }

        public decimal? AccountsReceivables { get; set; }

        public decimal? Inventory { get; set; }

        public decimal? AccountsPayables { get; set; }

        public decimal? OtherWorkingCapital { get; set; }

        public decimal? OtherNonCashItems { get; set; }

        [Required]
        public decimal NetCashProvidedByOperatingActivities { get; set; }

        public decimal? InvestmentsInPropertyPlantAndEquipment { get; set; }

        public decimal? AcquisitionsNet { get; set; }

        public decimal? PurchasesOfInvestments { get; set; }

        public decimal? SalesMaturitiesOfInvestments { get; set; }

        public decimal? OtherInvestingActivities { get; set; }

        [Required]
        public decimal NetCashUsedForInvestingActivities { get; set; }

        public decimal? DebtRepayment { get; set; }

        public decimal? CommonStockIssued { get; set; }

        public decimal? CommonStockRepurchased { get; set; }

        public decimal? DividendsPaid { get; set; }

        public decimal? OtherFinancingActivities { get; set; }

        [Required]
        public decimal NetCashUsedProvidedByFinancingActivities { get; set; }

        public decimal? EffectOfForexChangesOnCash { get; set; }

        [Required]
        public decimal NetChangeInCash { get; set; }

        [Required]
        public decimal CashAtEndOfPeriod { get; set; }

        [Required]
        public decimal CashAtBeginningOfPeriod { get; set; }

        [Required]
        public decimal OperatingCashFlow { get; set; }

        [Required]
        public decimal CapitalExpenditure { get; set; }

        [Required]
        public decimal FreeCashFlow { get; set; }

        public string Link { get; set; }

        public string FinalLink { get; set; }
    }

}
