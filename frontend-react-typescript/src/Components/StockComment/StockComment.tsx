import { toast } from "react-toastify";
import StockCommentForm from "./StockCommentForm/StockCommentForm";
import { commentGetApi, commentPostApi } from "../../Services/CommentServices";
import { CommentGet } from "../../Models/Comment";
import { useEffect, useState } from "react";
import Spinner from "../../Spinner/Spinner";
import StockCommentList from "../StockCommentList/StockCommentList";

type Props = {
    stockSymbol: string;
  };
  
  type CommentFormInputs = {
    title: string;
    content: string;
  };
  
  const StockComment = ({ stockSymbol }: Props) => {

    const [comments, setComments] = useState<CommentGet[]>();
    const [loading, setLoading] = useState<boolean>();

    const getComments = () =>{
      setLoading(true);

      commentGetApi(stockSymbol).then((res) => {
        setLoading(false);
        setComments(res?.data);
      });
    }

    useEffect(()=>{
      getComments();
    },[])
    
    const handleComment = (e: CommentFormInputs) => {
      commentPostApi(e.title, e.content, stockSymbol)
        .then((res) => {
          if (res) {
            toast.success("Comment created successfully!");
            getComments();
          }
        })
        .catch((e) => {
          toast.warning(e);
        });
    };
    return (
      <div className="flex flex-col">
      {loading ? <Spinner /> : <StockCommentList comments={comments!} />}
      <StockCommentForm symbol={stockSymbol} handleComment={handleComment} />
    </div>
    );
  };
  
  export default StockComment;