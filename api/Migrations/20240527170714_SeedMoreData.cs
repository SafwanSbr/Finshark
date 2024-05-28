using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8df455ac-1c12-46bb-b1b0-d81733bbb6b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99ae2263-cb47-4dcf-966a-3e98998417e2");

            migrationBuilder.CreateTable(
                name: "companyBalanceSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalendarYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CashAndCashEquivalents = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortTermInvestments = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAndShortTermInvestments = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetReceivables = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Inventory = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCurrentAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCurrentAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PropertyPlantEquipmentNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Goodwill = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IntangibleAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GoodwillAndIntangibleAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LongTermInvestments = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherNonCurrentAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalNonCurrentAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountPayables = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortTermDebt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxPayables = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeferredRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherCurrentLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalCurrentLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LongTermDebt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeferredRevenueNonCurrent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DeferredTaxLiabilitiesNonCurrent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherNonCurrentLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalNonCurrentLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CapitalLeaseObligations = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreferredStock = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CommonStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RetainedEarnings = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccumulatedOtherComprehensiveIncomeLoss = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherTotalStockholdersEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalStockholdersEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalLiabilitiesAndStockholdersEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinorityInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalLiabilitiesAndTotalEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalInvestments = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDebt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetDebt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyBalanceSheets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "companyCashFlows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalendarYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepreciationAndAmortization = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeferredIncomeTax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StockBasedCompensation = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ChangeInWorkingCapital = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccountsReceivables = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Inventory = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccountsPayables = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherWorkingCapital = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherNonCashItems = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetCashProvidedByOperatingActivities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvestmentsInPropertyPlantAndEquipment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AcquisitionsNet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PurchasesOfInvestments = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalesMaturitiesOfInvestments = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherInvestingActivities = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetCashUsedForInvestingActivities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DebtRepayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CommonStockIssued = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CommonStockRepurchased = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DividendsPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherFinancingActivities = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetCashUsedProvidedByFinancingActivities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EffectOfForexChangesOnCash = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetChangeInCash = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAtEndOfPeriod = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAtBeginningOfPeriod = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperatingCashFlow = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapitalExpenditure = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FreeCashFlow = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyCashFlows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "companyIncomeStatements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalendarYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Revenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostOfRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossProfitRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResearchAndDevelopmentExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GeneralAndAdministrativeExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SellingAndMarketingExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SellingGeneralAndAdministrativeExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OperatingExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostAndExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InterestIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InterestExpense = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DepreciationAndAmortization = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EBITDA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EBITDARatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperatingIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperatingIncomeRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalOtherIncomeExpensesNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeBeforeTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeBeforeTaxRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeTaxExpense = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetIncomeRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EPS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EPSDiluted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeightedAverageShsOut = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeightedAverageShsOutDil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyIncomeStatements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "companyKeyMetrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevenuePerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetIncomePerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperatingCashFlowPerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FreeCashFlowPerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashPerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookValuePerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TangibleBookValuePerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShareholdersEquityPerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InterestDebtPerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketCapTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EnterpriseValueTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PeRatioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceToSalesRatioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PocfratioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PfcfRatioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PbRatioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PtbRatioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EvToSalesTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EnterpriseValueOverEBITDATTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EvToOperatingCashFlowTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EvToFreeCashFlowTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EarningsYieldTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FreeCashFlowYieldTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DebtToEquityTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DebtToAssetsTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetDebtToEBITDATTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentRatioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InterestCoverageTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeQualityTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DividendYieldTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DividendYieldPercentageTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayoutRatioTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesGeneralAndAdministrativeToRevenueTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResearchAndDevelopementToRevenueTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IntangiblesToTotalAssetsTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapexToOperatingCashFlowTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapexToRevenueTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapexToDepreciationTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockBasedCompensationToRevenueTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrahamNumberTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoicTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnOnTangibleAssetsTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrahamNetNetTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkingCapitalTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TangibleAssetValueTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetCurrentAssetValueTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvestedCapitalTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageReceivablesTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AveragePayablesTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageInventoryTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaysSalesOutstandingTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaysPayablesOutstandingTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaysOfInventoryOnHandTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivablesTurnoverTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayablesTurnoverTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InventoryTurnoverTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoeTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapexPerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DividendPerShareTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DebtToMarketCapTTM = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyKeyMetrics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "companyTenKs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcceptedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyTenKs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02b32b52-795e-4fe4-bd1b-03b2d2eaecbf", null, "Admin", "ADMIN" },
                    { "9f44658f-284a-4fd7-9069-674a570a9e69", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companyBalanceSheets");

            migrationBuilder.DropTable(
                name: "companyCashFlows");

            migrationBuilder.DropTable(
                name: "companyIncomeStatements");

            migrationBuilder.DropTable(
                name: "companyKeyMetrics");

            migrationBuilder.DropTable(
                name: "companyTenKs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02b32b52-795e-4fe4-bd1b-03b2d2eaecbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f44658f-284a-4fd7-9069-674a570a9e69");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8df455ac-1c12-46bb-b1b0-d81733bbb6b9", null, "User", "USER" },
                    { "99ae2263-cb47-4dcf-966a-3e98998417e2", null, "Admin", "ADMIN" }
                });
        }
    }
}
