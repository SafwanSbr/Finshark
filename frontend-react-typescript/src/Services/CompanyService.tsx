import axios from "axios";
import { SearchResponse } from "../api";
import { CompanyProfile } from "../company";
import { handleError } from "../Helpers/ErrorHandler";

const api = "https://localhost:7087/api/stock";

export const searchCompanies = async (query: string) => {
    try {
      const data = await axios.get<SearchResponse>(api + `?Symbol=${query}`);
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
            `https://localhost:7087/api/stock?Symbol=${query}`
        );
        return data;
    } catch (error: any){
        handleError(error);
        console.log("Error Message from API: ", error);
    }
}