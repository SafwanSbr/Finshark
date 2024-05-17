import axios from "axios"
import { CompanyProfile, CompanySearch } from "./company";

const api_key = 'eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InNhZDEyM0BleGFtcGxlLmNvbSIsImdpdmVuX25hbWUiOiJzYWQiLCJuYmYiOjE3MTU3NTQ4OTgsImV4cCI6MTcxNjk2NDQ5OCwiaWF0IjoxNzE1NzU0ODk4LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo3MDg3IiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzA4NyJ9.N6rQfhWpfS3MfhIkJkcmI7uDofvCrKsZwvle8hsHz5fH3WJumVT-8ilQEbYEApLg77O9G_qEaHdsr6eYWD-84Q';

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
        console.log("Error Message from API: ", error.message);
    }
}