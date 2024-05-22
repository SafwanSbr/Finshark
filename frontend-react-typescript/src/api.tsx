import axios from "axios"
import { CompanyBalanceSheet, CompanyCashFlow, CompanyCompData, CompanyIncomeStatement, CompanyKeyMetrics, CompanyProfile, CompanySearch, CompanyTenK } from "./company";

const api_key = 'eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InNhZDEyM0BleGFtcGxlLmNvbSIsImdpdmVuX25hbWUiOiJzYWQiLCJuYmYiOjE3MTU3NTQ4OTgsImV4cCI6MTcxNjk2NDQ5OCwiaWF0IjoxNzE1NzU0ODk4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDg3IiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzA4NyJ9.N6rQfhWpfS3MfhIkJkcmI7uDofvCrKsZwvle8hsHz5fH3WJumVT-8ilQEbYEApLg77O9G_qEaHdsr6eYWD-84Q';
const web_api_key = '7de6e7e5b2f29076903ea31b019f70cd';

export interface SearchResponse {
    data: CompanySearch[];
}


//Search 
export const searchCompanies = async (query: string) => {
    try {
      const data = await axios.get<SearchResponse>(
        `https://localhost:7087/api/stock?Symbol=${query}`,
        {
          headers: {
            Authorization: `Bearer ${api_key}`, // Assuming 'api_key' is your access token
          },
        }
      );
      return data;
    } catch (error) {
      if (axios.isAxiosError(error)) {
        console.log("Error Message: ", error);
        // Handle specific errors (e.g., 401 for unauthorized access)
        if (error.status === 401) {
          console.error("Unauthorized access. Check your access token.");
        }
        return error.message;
      } else {
        console.log("Unexpected error: ", error);
        return ("An Expected error occured.");
      }
    }
  };
  

//Get Specific Company
export const getCompanyProfile = async (query: string) =>{
    try {
        console.log(query)
        const data = await axios.get<CompanyProfile[]>(
            `https://localhost:7087/api/stock?Symbol=${query}`,
        {
          headers: {
            Authorization: `Bearer ${api_key}`, // Assuming 'api_key' is your access token
          },
        }
        );
        return data;
    } catch (error: any){
        console.log("Error Message from API: ", error);
    }
}

export const getKeyMetrics = async (query: string) => {
  try{
    const data = await axios.get<CompanyKeyMetrics[]>(
      `https://financialmodelingprep.com/api/v3/key-metrics-ttm/${query}?limit=40&apikey=${web_api_key}`);

    return data;
  } catch(error: any){
    console.log("Error from API: ", error.message);
  }
}

export const getIncomeStatement = async (query: string) =>{
  try{
    const data = await axios.get<CompanyIncomeStatement[]>(`https://financialmodelingprep.com/api/v3/income-statement/${query}?limit=40&apikey=${web_api_key}`);
    return data;
  } catch( error: any){
    console.log("Api error: ", error);
  }
}

export const getBalanceSheet = async (query: string) =>{
  try{
    const data = await axios.get<CompanyBalanceSheet[]>(`https://financialmodelingprep.com/api/v3/balance-sheet-statement/${query}?limit=20&apikey=${web_api_key}`);
    return data;
  } catch(error: any){
    console.log("Api error: ", error);
  }
}

export const getCashFlow = async (query: string) => {
  try {
    const data = await axios.get<CompanyCashFlow[]>(
      `https://financialmodelingprep.com/api/v3/cash-flow-statement/${query}?limit=100&apikey=${web_api_key}`
    );
    return data;
  } catch (error: any) {
    console.log("error message: ", error);
  }
};

export const getCompanyData = async (query: string) => {
  try{
    const data = await axios.get<CompanyCompData[]>(`https://financialmodelingprep.com/api/v4/stock_peers?symbol=${query}&apikey=${web_api_key}`);
    return data;
  } catch(error: any){
    console.log("Api Error:- " , error);// Subscription problem
  }
}

export const getTenK = async (query: string)=>{
  try{
    const data = await axios.get<CompanyTenK[]>(`https://financialmodelingprep.com/api/v3/sec_filings/${query}?type=10-K&page=0&apikey=${web_api_key}`);
    return data;
  } catch(error){
    console.log("getTasK Api Error: ", error);
  }
}