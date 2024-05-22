import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import HomePage from "../Page/HomePage/HomePage";
import SearchPage from "../Page/SearchPage/SearchPage";
import CompanyPage from "../Page/CompanyPage/CompanyPage";
import CompanyProfile from "../Components/CompanyProfile/CompanyProfile";
import IncomeStatement from "../Components/IncomeStatement/IncomeStatement";
import DesignGuide from "../Page/DesignGuide/DesignGuide";
import BalanceSheet from "../Components/BalanceSheet/BalanceSheet";
import CashflowStatement from "../Components/CashflowStatement/CashflowStatement";
import RegistrationPage from "../Page/RegistrationPage/RegistrationPage";
import LoginPage from "../Page/LoginPage/LoginPage";
import ProtectedRoute from "./ProtectedRoute"

export const router = createBrowserRouter([
    {
        path: "/",
        element: <App/>,
        children: [
            { path: "/", element: <HomePage /> },
            {
                path: "search",
                element: (
                  <ProtectedRoute>
                    <SearchPage />
                  </ProtectedRoute>
                ),
              },
            { path: "login", element: <LoginPage /> },
            { path: "register", element: <RegistrationPage /> },
            { path: "design-guide", element: <DesignGuide />},
            { 
                path: "company/:ticker",
                element: (
                    <ProtectedRoute>
                      <CompanyPage />
                    </ProtectedRoute>
                  ),
                children: [
                    {path: "company-profile/", element: <CompanyProfile/>},
                    {path: "income-statement", element: <IncomeStatement/>},
                    {path: "balance-sheet", element: <BalanceSheet/>},
                    {path: "cashflow-statement", element: <CashflowStatement/>}
                ]
            },  
        ]
    }
])