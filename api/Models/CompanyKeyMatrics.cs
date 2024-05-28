using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CompanyKeyMetrics
    {
        [Key]
        public int Id { get; set; } // Assuming a primary key

        [Required]
        public string Symbol { get; set; }

        [Required]
        public decimal RevenuePerShareTTM { get; set; }

        [Required]
        public decimal NetIncomePerShareTTM { get; set; }

        [Required]
        public decimal OperatingCashFlowPerShareTTM { get; set; }

        [Required]
        public decimal FreeCashFlowPerShareTTM { get; set; }

        [Required]
        public decimal CashPerShareTTM { get; set; }

        [Required]
        public decimal BookValuePerShareTTM { get; set; }

        [Required]
        public decimal TangibleBookValuePerShareTTM { get; set; }

        [Required]
        public decimal ShareholdersEquityPerShareTTM { get; set; }

        [Required]
        public decimal InterestDebtPerShareTTM { get; set; }

        [Required]
        public decimal MarketCapTTM { get; set; }

        [Required]
        public decimal EnterpriseValueTTM { get; set; }

        [Required]
        public decimal PeRatioTTM { get; set; }

        [Required]
        public decimal PriceToSalesRatioTTM { get; set; }

        [Required]
        public decimal PocfratioTTM { get; set; }

        [Required]
        public decimal PfcfRatioTTM { get; set; }

        [Required]
        public decimal PbRatioTTM { get; set; }

        [Required]
        public decimal PtbRatioTTM { get; set; }

        [Required]
        public decimal EvToSalesTTM { get; set; }

        [Required]
        public decimal EnterpriseValueOverEBITDATTM { get; set; }

        [Required]
        public decimal EvToOperatingCashFlowTTM { get; set; }

        [Required]
        public decimal EvToFreeCashFlowTTM { get; set; }

        [Required]
        public decimal EarningsYieldTTM { get; set; }

        [Required]
        public decimal FreeCashFlowYieldTTM { get; set; }

        [Required]
        public decimal DebtToEquityTTM { get; set; }

        [Required]
        public decimal DebtToAssetsTTM { get; set; }

        [Required]
        public decimal NetDebtToEBITDATTM { get; set; }

        [Required]
        public decimal CurrentRatioTTM { get; set; }

        [Required]
        public decimal InterestCoverageTTM { get; set; }

        [Required]
        public decimal IncomeQualityTTM { get; set; }

        [Required]
        public decimal DividendYieldTTM { get; set; }

        [Required]
        public decimal DividendYieldPercentageTTM { get; set; }

        [Required]
        public decimal PayoutRatioTTM { get; set; }

        [Required]
        public decimal SalesGeneralAndAdministrativeToRevenueTTM { get; set; }

        [Required]
        public decimal ResearchAndDevelopementToRevenueTTM { get; set; }

        [Required]
        public decimal IntangiblesToTotalAssetsTTM { get; set; }

        [Required]
        public decimal CapexToOperatingCashFlowTTM { get; set; }

        [Required]
        public decimal CapexToRevenueTTM { get; set; }

        [Required]
        public decimal CapexToDepreciationTTM { get; set; }

        [Required]
        public decimal StockBasedCompensationToRevenueTTM { get; set; }

        [Required]
        public decimal GrahamNumberTTM { get; set; }

        [Required]
        public decimal RoicTTM { get; set; }

        [Required]
        public decimal ReturnOnTangibleAssetsTTM { get; set; }

        [Required]
        public decimal GrahamNetNetTTM { get; set; }

        [Required]
        public decimal WorkingCapitalTTM { get; set; }

        [Required]
        public decimal TangibleAssetValueTTM { get; set; }

        [Required]
        public decimal NetCurrentAssetValueTTM { get; set; }

        [Required]
        public decimal InvestedCapitalTTM { get; set; }

        [Required]
        public decimal AverageReceivablesTTM { get; set; }

        [Required]
        public decimal AveragePayablesTTM { get; set; }

        [Required]
        public decimal AverageInventoryTTM { get; set; }

        [Required]
        public decimal DaysSalesOutstandingTTM { get; set; }

        [Required]
        public decimal DaysPayablesOutstandingTTM { get; set; }

        [Required]
        public decimal DaysOfInventoryOnHandTTM { get; set; }

        [Required]
        public decimal ReceivablesTurnoverTTM { get; set; }

        [Required]
        public decimal PayablesTurnoverTTM { get; set; }

        [Required]
        public decimal InventoryTurnoverTTM { get; set; }

        [Required]
        public decimal RoeTTM { get; set; }

        [Required]
        public decimal CapexPerShareTTM { get; set; }

        [Required]
        public decimal DividendPerShareTTM { get; set; }

        [Required]
        public decimal DebtToMarketCapTTM { get; set; }
    }
}
