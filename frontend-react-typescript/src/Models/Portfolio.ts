export type PortfolioGet = {
    id: number;
    symbol: string;
    companyName: string;
    purchase: number;
    lastDiv: number;
    industry: string;
    marketCap: string;
    commments: any;
};

export type PortfolioPost = {
    symbol: string;
}