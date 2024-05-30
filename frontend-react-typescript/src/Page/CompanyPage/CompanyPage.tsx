import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router'
import { CompanyProfile } from '../../company';
import { getCompanyProfile } from '../../Services/CompanyService';
import Sidebar from '../../Components/Sidebar/Sidebar';
import CompanyDashboard from '../../Components/CompanyDashboard/CompanyDashboard';
import Title from '../../Components/Title/Title';
import Spinner from '../../Spinner/Spinner';
import TenKFinder from '../../Components/TenKFinder/TenKFinder';
import CompanyFinder from '../../Components/CompanyFinder/CompanyFinder';

interface Props {}

const CompanyPage = (props: Props) => {
  
  let {ticker} = useParams();

  const [company, setCompany] = useState<CompanyProfile>();
  const [error, setError] = useState<string | null>(null);
  
  useEffect(  () => {
    const getProfileInit = async () => {
      try {
        const data = await getCompanyProfile(ticker!);
        setCompany(data?.data[0]);
        console.log(data);
      } catch (error: any) {
        if (error.response?.status === 429) {
          setError("Too many requests. Please try again later.");
        } else {
          setError("An error occurred while fetching company data.");
        }
      }
    };

    getProfileInit();
  }, [ticker]);

  return (
    <>
      {company ? (
        <div className="w-full relative flex ct-docs-disable-sidebar-content overflow-x-hidden">
          
          <Sidebar />
          
          <CompanyDashboard ticker = {ticker!}>
            <Title title="Company Name" subTitle={company.companyName} />
            <Title title="Industry" subTitle={ company.industry?.toString()} />
            <Title title="Market Cap" subTitle={"$" + company.marketCap?.toString()} />
            <CompanyFinder ticker={company.symbol} />
            <TenKFinder ticker={company.symbol} />
          </CompanyDashboard>
        </div>

      ) : error ? (
        <div>{error}</div>
      ) : (
        <Spinner/>
      )}
    </>
  );
}

export default CompanyPage