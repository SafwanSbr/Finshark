import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router'
import { CompanyProfile } from '../../company'
import { getCompanyProfile } from '../../api'

type Props = {}

const CompanyPage = (props: Props) => {

    let {ticker} = useParams();
    const [company, setCompany] = useState<CompanyProfile>();
    
    useEffect(()=>{
      const getProfileInit = async ()=>{
        const data = await getCompanyProfile(ticker!);
        setCompany(data?.data[0]);
      }
    }, []);

    return(
      <>
        {company? (
          <div>{company.companyName}</div>
        ):(
          <div> Company not Found! </div>
        )}
      </>
    );
}

export default CompanyPage