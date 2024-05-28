import React from 'react'
import { CommentGet } from '../../Models/Comment'

type Props = {
    comments: CommentGet;
}

const StockCommentListItem = ({ comments }: Props) => {

  // Function to format the date
  const formatDate = (dateString: string) => {
    const options: Intl.DateTimeFormatOptions = {
      year: 'numeric',
      month: 'long',
      day: 'numeric',
      hour: '2-digit',
      minute: '2-digit',
    };
    return new Date(dateString).toLocaleDateString(undefined, options);
  };

  return (
    <div className="relative grid grid-cols-1 gap-4 ml-4 p-4 mb-8 w-full border rounded-lg bg-white shadow-lg">
      <div className="relative flex gap-4">
        <div className="flex flex-col w-full">
          <div className="flex flex-row justify-between">
            <p className="relative text-xl whitespace-nowrap truncate overflow-hidden">
              {comments.title}
            </p>
          </div>
          <p className="text-dark text-sm">@{comments.userName}</p>
          <p className="text-dark text-sm">{formatDate(comments.createdOn)}</p> {/* Add this line */}
        </div>
      </div>
      <p className="-mt-4 text-gray-500">{comments.content}</p>
    </div>
  )
}

export default StockCommentListItem
