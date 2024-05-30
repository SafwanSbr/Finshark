import React from 'react'
import { CommentGet } from '../../Models/Comment'
import StockCommentListItem from '../StockCommentListItem/StockCommentListItem';
import { v4 as uuidv4} from "uuid"

type Props = {
    comments: CommentGet[];
};

const StockCommentList = ({comments}: Props) => {
  return (
    <>
        {comments? comments.map((comment) =>{
            return <StockCommentListItem comments={comment} key={uuidv4()}/>
        }) : ""}
    </>
  )
}

export default StockCommentList