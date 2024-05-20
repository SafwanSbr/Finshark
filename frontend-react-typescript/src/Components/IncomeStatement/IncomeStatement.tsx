import React, { useEffect, useState } from 'react';
import { CompanyIncomeStatement } from '../../company';
import { useOutletContext } from 'react-router';
import Table from '../Table/Table';
import { getIncomeStatement } from '../../api';
import { formatLargeMonetaryNumber, formatRatio } from '../../Helpers/NumberFormatting';

const configs = [
  {
    label: "Date",
    render: (company: CompanyIncomeStatement) => company.date,
  },
  {
    label: "Revenue",
    render: (company: CompanyIncomeStatement) =>
      formatLargeMonetaryNumber(company.revenue),
  },
  {
    label: "Cost Of Revenue",
    render: (company: CompanyIncomeStatement) =>
      formatLargeMonetaryNumber(company.costOfRevenue),
  },
  {
    label: "Depreciation",
    render: (company: CompanyIncomeStatement) =>
      formatLargeMonetaryNumber(company.depreciationAndAmortization),
  },
  {
    label: "Operating Income",
    render: (company: CompanyIncomeStatement) =>
      formatLargeMonetaryNumber(company.operatingIncome),
  },
  {
    label: "Income Before Taxes",
    render: (company: CompanyIncomeStatement) =>
      formatLargeMonetaryNumber(company.incomeBeforeTax),
  },
  {
    label: "Net Income",
    render: (company: CompanyIncomeStatement) =>
      formatLargeMonetaryNumber(company.netIncome),
  },
  {
    label: "Net Income Ratio",
    render: (company: CompanyIncomeStatement) =>
      formatRatio(company.netIncomeRatio),
  },
  {
    label: "Earnings Per Share",
    render: (company: CompanyIncomeStatement) => formatRatio(company.eps),
  },
  {
    label: "Earnings Per Diluted",
    render: (company: CompanyIncomeStatement) =>
      formatRatio(company.epsdiluted),
  },
  {
    label: "Gross Profit Ratio",
    render: (company: CompanyIncomeStatement) =>
      formatRatio(company.grossProfitRatio),
  },
  {
    label: "Opearting Income Ratio",
    render: (company: CompanyIncomeStatement) =>
      formatRatio(company.operatingIncomeRatio),
  },
  {
    label: "Income Before Taxes Ratio",
    render: (company: CompanyIncomeStatement) =>
      formatRatio(company.incomeBeforeTaxRatio),
  },
];
	

type Props = {}

const IncomeStatement = (props: Props) => {
  const ticker = useOutletContext<string>();
  const [incomeStatement, setIncomeStatement] = useState<CompanyIncomeStatement[]>([]); //Initialy empty array

  useEffect(() => {
    const getRatios = async () => {
      const resultArray = await getIncomeStatement(ticker!);
      setIncomeStatement(resultArray?.data ?? []); //Check if the data got successfully or sending empty array
    };
    getRatios();
  }, [ticker]);

  return (
    <>
      {incomeStatement.length > 0 ? ( //The check incomeStatement.length > 0 ensures the component waits for the data to be available before rendering the Table component.
        <Table config={configs} data={incomeStatement} />
      ) : (
        <h1>Could not find income statement!</h1>
      )}
    </>
  );
}

export default IncomeStatement;
