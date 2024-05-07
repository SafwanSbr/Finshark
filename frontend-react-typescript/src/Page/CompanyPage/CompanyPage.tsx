import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router'
import { CompanyProfile } from '../../company';
import { getCompanyProfile } from '../../api';

type Props = {}

const CompanyPage = (props: Props) => {
  
  let {ticker} = useParams();

  const [company, setCompany] = useState<CompanyProfile>();
  const [error, setError] = useState<string | null>(null);

  useEffect(  () => {
    const getProfileInit = async () => {
      try {
        const data = await getCompanyProfile(ticker!);
        setCompany(data?.data[0]);
      } catch (error: any) {
        if (error.response?.status === 429) {
          setError("Too many requests. Please try again later.");
        } else {
          setError("An error occurred while fetching company data.");
        }
      }
    };

    getProfileInit();
  }, []);

  return (
    <>
      {company ? (
        <div>{company.companyName}</div>
      ) : error ? (
        <div>{error}</div>
      ) : (
        <div>Loading company data...</div>
      )}
    </>
  );
}

export default CompanyPage