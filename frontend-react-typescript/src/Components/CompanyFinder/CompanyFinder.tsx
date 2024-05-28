import React, { useEffect, useState } from 'react'
import { CompanyCompData } from '../../company';
import { getCompanyData } from '../../api';
import CompanyFinderItem from '../CompanyFinderItem/CompanyFinderItem';

type Props = {
    ticker: string;
}

const CompanyFinder = ({ticker}: Props) => {
    
    const [companyData, setCompanyData] = useState<CompanyCompData>();

    useEffect(()=>{
        const getComps = async ()=>{
            const value = await getCompanyData(ticker);
            setCompanyData(value?.data);
        };
        getComps();
    }, [ticker]);

    return (
    <div className='inline-flex rounded-md shadow-sm m-4'>
        {companyData?.peersList.map((ticker) => {
            return <CompanyFinderItem  ticker={ticker}/>
        })}
    </div>
  )
}

export default CompanyFinder