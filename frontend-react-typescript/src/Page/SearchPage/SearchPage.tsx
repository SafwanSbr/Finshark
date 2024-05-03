import { useState, ChangeEvent, SyntheticEvent } from "react";
import CardList from "../../Components/CardList/CardList";
import Hero from "../../Components/Hero/Hero";
import Navbar from "../../Components/Navber/Navbar";
import { searchCompanies } from "../../api";
import { CompanySearch } from "../../company";
import Search from "../../Components/Search/Search";
import ListPortfolio from "../../Components/Portfolio/ListPortfolio/ListPortfolio";


type Props = {}

const SearchPage = (props: Props) => {
  const [search, setSearch] = useState<string>("");
  const [searchResult, setSearchResult] = useState<CompanySearch[]>([]);
  const [portfolioValue, setPortfolioValue] = useState<string[]>([]);
  const [serverError, setServerError] = useState<string>("");

  //-------------------------Search
  const handleSearchChange = (e: ChangeEvent<HTMLInputElement>) => {
    setSearch(e.target.value);
    console.log(e);
  }

  const handleSearchClick = async (e: SyntheticEvent) =>{
    e.preventDefault();
    const result = await searchCompanies(search);
    //setSearchResult(result.) //need type Narrowing (doing on next line->)

    if(typeof result === "string"){
      setServerError(result);
    } else if(Array.isArray(result.data)){
      setSearchResult(result.data);
    }
  }

  //----------------------Portfolio
  //Add into Portfolio
  const onPortfolioAddClick = (e: any) =>{
    e.preventDefault();

    //Not allow one company multiple times
    const isExists = portfolioValue.find((value)=> value === e.target[0].value)
    if(isExists) return;

    const newPortfolioValues = [...portfolioValue, e.target[0].value]
    setPortfolioValue(newPortfolioValues);
  }

  //Delete from Portfolio
  const onPortfolioDelete = (e: any) => {
    const isExists = portfolioValue.find((value) => value === e.target[0].value);
    if(!isExists) return;

    const newPortfolioValues = portfolioValue.filter( (value)=>{
      return (value !== e.target[0].value);
    })
    setPortfolioValue(newPortfolioValues);
  }
  return (
    <div className="App">

      {/* <Navbar/> */}
      {/* <Hero/> */}

      {/*{serverError ? <h2>{serverError}</h2> : <Search handleClick={handleClick} handleChange={handleChange} search={search} />}*/}

      <Search handleSearchClick={handleSearchClick} handleSearchChange={handleSearchChange} search={search}/>
      <ListPortfolio portfolioValues={portfolioValue} onPortfolioDelete={onPortfolioDelete}/>
      <CardList searchResult = {searchResult} onPortfolioAddClick={onPortfolioAddClick}/>
    </div>
  )
}

export default SearchPage