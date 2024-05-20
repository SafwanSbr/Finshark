import { SyntheticEvent } from "react";
import { CompanySearch } from "../../company";
import AddProtfolio from "../Portfolio/AddPortfolio/AddPortfolio";
import "./Card.css"
import { Link } from "react-router-dom";

interface Props {
  id:string;
  searchedData: CompanySearch;
  onPortfolioAddClick: (e: SyntheticEvent) => void;
}

const Card: React.FC<Props> = ({id, searchedData, onPortfolioAddClick}: Props) : JSX.Element => {
  return (
    <div
      className="flex flex-col items-center justify-between w-full p-6 bg-slate-100 rounded-lg md:flex-row"
      key={id}
      id={id}
    >
      <Link to={`/company/${searchedData.symbol}/company-profile`} className="font-bold text-center text-black md:text-left">
        {searchedData.name} ({searchedData.symbol})
      </Link>
      <p className="text-black">{searchedData.currency}</p>
      <p className="font-bold text-black">
        {searchedData.exchangeShortName} - {searchedData.stockExchange}
      </p>
      <AddProtfolio
        onPortfolioAddClick={onPortfolioAddClick}
        id={searchedData.symbol}
      />
    </div>
  )
}

export default Card