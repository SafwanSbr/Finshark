import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router'
import { CompanyProfile } from '../../company';
import { getCompanyProfile } from '../../api';
import Sidebar from '../../Components/Sidebar/Sidebar';
import CompanyDashboard from '../../Components/CompanyDashboard/CompanyDashboard';
import { error } from 'console';
import Title from '../../Components/Title/Title';

interface Props {}

const CompanyPage = (props: Props) => {
  
  let {ticker} = useParams();

  const tabItems = [
    {
      id: 1,
      title: "Company Profile",
      icon: "fas fa-child",
      content: "step 1 content"
    },
    {
      id: 2,
      title: "Income Statment",
      icon: "fas fa-users",
      content: "step 2 content"
    },
    {
      id: 3,
      title: "Balance Sheet",
      icon: "fas fa-network-wired",
      content: "step 3 content"
    },
    {
      id: 4,
      title: "Cash Flow",
      icon: "fa money-check-alt",
      content: "step 4 content"
    }
  ]

  const [company, setCompany] = useState<CompanyProfile>();
  const [error, setError] = useState<string | null>(null);
  const [ activeSidebarItem, setActiveSideBarItem] = useState<number>(1);

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
  }, []);

  return (
    <>
      {company ? (
        <div className="w-full relative flex ct-docs-disable-sidebar-content overflow-x-hidden">
          
          <Sidebar />
          
          <CompanyDashboard>
            <Title title="Company Name" subTitle={company.companyName} />
          </CompanyDashboard>
        </div>

      ) : error ? (
        <div>{error}</div>
      ) : (
        <div>Loading company data...</div>
      )}
    </>
  );
}

export default CompanyPage