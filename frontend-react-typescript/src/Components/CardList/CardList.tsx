import React, { SyntheticEvent } from 'react'
import Card from '../Card/Card'
import { CompanyBalanceSheet, CompanySearch } from '../../company'
import { v4 as uuidv4} from "uuid"

interface Props {
  searchResult: CompanySearch[];
  onPortfolioAddClick: (e: SyntheticEvent) => void;

}

const CardList: React.FC<Props> = ({searchResult, onPortfolioAddClick}: Props) : JSX.Element => {
  return (
    <div>
      {searchResult.length > 0 ? (
        searchResult.map((data) => {
          return <Card id={data.symbol} key={uuidv4()} searchedData={data} onPortfolioAddClick={onPortfolioAddClick}/>
        })
      ) : (
        <p className="mb-3 mt-3 text-xl font-semibold text-center md:text-xl">
          No results!
        </p>
      )}
    </div>
  )
}

export default CardList;