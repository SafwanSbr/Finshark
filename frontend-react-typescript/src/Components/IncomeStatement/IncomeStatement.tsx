import React, { useEffect, useState } from 'react';
import { CompanyIncomeStatement } from '../../company';
import { useOutletContext } from 'react-router';
import Table from '../Table/Table';
import { getIncomeStatement } from '../../api';

const configs = [
  {
    label: "Date",
    render: (company: CompanyIncomeStatement) => company.date,
  },
  {
    label: "Total Revenue",
    render: (company: CompanyIncomeStatement) => company.netIncome,
  },
  {
    label: "Net Income",
    render: (company: CompanyIncomeStatement) => company.netIncome,
  },
  {
    label: "Operating Expenses",
    render: (company: CompanyIncomeStatement) => company.operatingExpenses,
  },
  {
    label: "Cost of Revenue",
    render: (company: CompanyIncomeStatement) => company.costOfRevenue,
  }
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
