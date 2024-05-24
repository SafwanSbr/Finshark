import axios from "axios";
import { handleError } from "../Helpers/ErrorHandler";
import { CommentPost, CommentGet } from "../Models/Comment";

const api = 'https://localhost:7087/api/comment/';

export const commentPostApi = async (title: string, content: string, symbol: string)=>{
    try{
        const data = await axios.post<CommentPost>(api + `${symbol}`,
        {
            title: title,
            content: content,
        });
        
            return data;
    } catch(error){
        handleError(error);
    }
}

export const commentGetApi = async (symbol: string) =>{
    try{
        const data = await axios.get<CommentGet[]>(api +`?Symbol=${symbol}`);
        return data;
    } catch( error ){
        handleError(error);
    }
}