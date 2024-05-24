import axios from 'axios';
import React from 'react'
import { handleError } from '../Helpers/ErrorHandler';
import { PortfolioGet, PortfolioPost } from '../Models/Portfolio';


const api = 'https://localhost:7087/api/portfolio';

export const portfolioAddApi = async (symbol:string) =>{
    try{
        const data = await axios.post<PortfolioPost>( api + `?symbol=${symbol}`);
        return data;
    } catch( error ){
        handleError(error);
    }
};

export const portfolioDeleteApi = async (symbol:string)=>{
    try{
        const data = await axios.delete<PortfolioPost>(api + `?Symbol=${symbol}`);
        return data;
    } catch(error) {
        handleError(error);
    }
}

export const portfolioGetApi = async (token: string)=>{
    try{
        const data = await axios.get<PortfolioGet[]>(api,
            {headers: { Authorization: `Bearer ${token}` }}
        );
        return data;
    }
    catch(error){
        handleError(error);
    }
}