import axios from "axios"
import { CompanyProfile, CompanySearch } from "./company";

const api_key = '7de6e7e5b2f29076903ea31b019f70cd';

export interface SearchResponse {
    data: CompanySearch[];
}


//Search 
export const searchCompanies = async (query: string) => {
    try{
        const data = await axios.get<SearchResponse>(
            `https://financialmodelingprep.com/api/v3/search?query=${query}&limit=10&exchange=NASDAQ&apikey=${api_key}`
          );
          return data;
    }catch(error){
        if(axios.isAxiosError(error)){
            console.log("Error Message: ", error);
            return error.message;
        }
        else{
            console.log("Unexpected error: ", error);
            return ("An Expected error occured.");
        }
    }
}

//Get Specific Company
export const getCompanyProfile = async (query: string) =>{
    try {
        console.log(query)
        const data = await axios.get<CompanyProfile[]>(
            `https://financialmodelingprep.com/api/v3/profile/${query}?apikey=${api_key}`
        );
        return data;
    } catch (error: any){
        console.log("Error Message from API: ", error.message);
    }
}