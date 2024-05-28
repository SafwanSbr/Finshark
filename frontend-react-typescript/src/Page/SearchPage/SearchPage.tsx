import { useState, ChangeEvent, SyntheticEvent, useEffect } from "react";
import CardList from "../../Components/CardList/CardList";
import { searchCompanies } from "../../Services/CompanyService";
import { CompanySearch } from "../../company";
import Search from "../../Components/Search/Search";
import ListPortfolio from "../../Components/Portfolio/ListPortfolio/ListPortfolio";
import { PortfolioGet } from "../../Models/Portfolio";
import { portfolioAddApi, portfolioDeleteApi, portfolioGetApi } from "../../Services/PortfolioService";
import { toast } from "react-toastify";
import { useAuth } from "../../Context/useAuth";


type Props = {}

const SearchPage = (props: Props) => {
  const { token } = useAuth();
  
  const [search, setSearch] = useState<string>("");
  const [searchResult, setSearchResult] = useState<CompanySearch[]>([]);
  const [portfolioValue, setPortfolioValue] = useState<PortfolioGet[] | null>([]);
  const [serverError, setServerError] = useState<string>("");


  useEffect(()=>{
    getPortfolio();
    console.log(token);
  },[token])

  const getPortfolio = ()=>{
    portfolioGetApi(token? token:"")
      .then((response) =>{
        if(response?.data){
          console.log(response?.data);
          setPortfolioValue(response?.data);
        }
      })
      .catch((error)=>{
        setPortfolioValue(null);
      })
  }

  //-------------------------Search
  const handleSearchChange = (e: ChangeEvent<HTMLInputElement>) => {
    setSearch(e.target.value);
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
    //const isExists = portfolioValue.find((value)=> value === e.target[0].value)
    portfolioAddApi(e.target[0].value)
      .then((response) =>{
        if(response?.status === 204){
          toast.success("Stock addded to portfolio");

          getPortfolio();
        }
      })
      .catch((error) =>{
        toast.warning("Couldn't add Stock to Portfolio!");
        console.log(error);
      });
  }

  //Delete from Portfolio
  const onPortfolioDelete = (e: any) => {
    e.preventDefault();
    console.log(e.target[0].value);

    portfolioDeleteApi(e.target[0].value)
      .then((response)=>{
        if(response?.status === 200){
          toast.success("Stock deleted from Portfolio");
          getPortfolio();
        }
      })
      .catch((error)=>{
          toast.warning("Could not delete the stock");
          console.log(error);
      })
  }
  return (
    <div className="App">

      {/* <Navbar/> */}
      {/* <Hero/> */}

      {/*{serverError ? <h2>{serverError}</h2> : <Search handleClick={handleClick} handleChange={handleChange} search={search} />}*/}

      <Search handleSearchClick={handleSearchClick} handleSearchChange={handleSearchChange} search={search}/>
      <ListPortfolio portfolioValues={portfolioValue!} onPortfolioDelete={onPortfolioDelete}/>
      <CardList searchResult = {searchResult} onPortfolioAddClick={onPortfolioAddClick}/>
    </div>
  )
}

export default SearchPage