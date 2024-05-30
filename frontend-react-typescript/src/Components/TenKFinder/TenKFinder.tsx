import React, { useEffect, useState } from 'react'
import { CompanyTenK } from '../../company';
import { getTenK } from '../../api';
import Spinner from '../../Spinner/Spinner';
import TenKFinderItem from '../TenKFinderItem/TenKFinderItem';

type Props = {
    ticker: string;
}

const TenKFinder = ({ticker}: Props) => {
  
  const [companyData, setCompanyData] = useState<CompanyTenK[]>();

  useEffect(() =>{
    const getTenkData = async ()=>{
        const value = await getTenK(ticker);
        setCompanyData(value?.data);
    };
    getTenkData();
  }, [ticker]);

  return (
    <div className="inline-flex rounded-md shadow-sm m-4" role="group">
      {companyData ? (
           <TenKFinderItem tenK={companyData[0]} />
        ) : (
        <Spinner />
      )}
    </div>
  )
}

export default TenKFinder