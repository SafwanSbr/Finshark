import axios from "axios"
import { CompanyBalanceSheet, CompanyCashFlow, CompanyCompData, CompanyIncomeStatement, CompanyKeyMetrics, CompanyProfile, CompanySearch, CompanyTenK } from "./company";
import { handleError } from "./Helpers/ErrorHandler";

const web_api_key = '7de6e7e5b2f29076903ea31b019f70cd';

export interface SearchResponse {
    data: CompanySearch[];
}


export const getKeyMetrics = async (query: string) => {
  try{
    const data = await axios.get<CompanyKeyMetrics[]>(
      `https://financialmodelingprep.com/api/v3/key-metrics-ttm/${query}?limit=40&apikey=${web_api_key}`);

    return data;
  } catch(error: any){
    handleError(error);
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