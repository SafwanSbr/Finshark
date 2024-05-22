import axios from "axios";
import { UserProfileToken } from "../Models/User";
import { handleError } from "../Helpers/ErrorHandler";

const api = 'https://localhost:7087/api/';

export const loginApi = async (username: string, password: string)=>{
    try{
        const data = await axios.post<UserProfileToken>(
            api + "account/login", 
            {
                username: username,
                password: password,
            }
        );
        return data;
    } catch(error){
        handleError(error);
    }
}

export const registerApi = async (email:string, username: string, password: string)=>{
    try{
        const data = await axios.post<UserProfileToken>(
            api + "Account/register", 
            {
                email: email,
                username: username,
                password: password,
            }
        );
        return data;
    } catch(error){
        handleError(error);
    }
}