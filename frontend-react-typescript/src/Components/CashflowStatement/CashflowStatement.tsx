import React, { useEffect, useState } from 'react'
import { CompanyCashFlow } from '../../company';
import { useOutletContext } from 'react-router';
import { getCashFlow } from '../../api';
import Table from '../Table/Table';
import Spinner from '../../Spinner/Spinner';


const config = [
    {
      label: "Date",
      render: (company: CompanyCashFlow) => company.date,
    },
    {
      label: "Operating Cashflow",
      render: (company: CompanyCashFlow) => company.operatingCashFlow,
    },
    {
      label: "Property/Machinery Cashflow",
      render: (company: CompanyCashFlow) =>
        company.investmentsInPropertyPlantAndEquipment,
    },
    {
      label: "Other Investing Cashflow",
      render: (company: CompanyCashFlow) => company.otherInvestingActivites,
    },
    {
      label: "Debt Cashflow",
      render: (company: CompanyCashFlow) =>
        company.netCashUsedProvidedByFinancingActivities,
    },
    {
      label: "CapEX",
      render: (company: CompanyCashFlow) => company.capitalExpenditure,
    },
    {
      label: "Free Cash Flow",
      render: (company: CompanyCashFlow) => company.freeCashFlow,
    },
  ];
  
type Props = {}

const CashflowStatement = (props: Props) => {
    const ticker = useOutletContext<string>();
    const [cashFlowData, setCashFlowDara] = useState<CompanyCashFlow[]>([]);
  
    useEffect(()=>{
        const getRatios = async ()=>{
            const result = await getCashFlow(ticker!);
            setCashFlowDara(result?.data ?? []);  //This ensures incomeStatement is always an array, preventing the data.map error.
        }
        getRatios();
    }, [])

    return (
    <>
    {cashFlowData ? (
        <Table config={config} data={cashFlowData}/>
    ):(
        <Spinner/>
    )}
    </>
  )
}

export default CashflowStatement