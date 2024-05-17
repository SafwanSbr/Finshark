import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import HomePage from "../Page/HomePage/HomePage";
import SearchPage from "../Page/SearchPage/SearchPage";
import CompanyPage from "../Page/CompanyPage/CompanyPage";
import CompanyProfile from "../Components/CompanyProfile/CompanyProfile";
import IncomeStatement from "../Components/IncomeStatement/IncomeStatement";
import DesignGuide from "../Page/DesignGuide/DesignGuide";

export const router = createBrowserRouter([
    {
        path: "/",
        element: <App/>,
        children: [
            { path: "/", element: <HomePage /> },
            { path: "search/", element: <SearchPage /> },
            { path: "design-guide", element: <DesignGuide />},
            { 
                path: "company/:ticker",
                element: <CompanyPage />,
                children: [
                    {path: "company-profile/", element: <CompanyProfile/>},
                    {path: "income-statement", element: <IncomeStatement/>}
                ]
            },  
        ]
    }
])