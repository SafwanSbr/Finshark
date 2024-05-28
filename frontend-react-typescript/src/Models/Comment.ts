export type CommentPost = {
    title: string,
    content: string
};

export type CommentGet = {
    title: string;
    content: string;
    userName: string;
    createdOn: string; // Add this line
}
