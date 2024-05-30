import { Link } from 'react-router-dom';

type Props = {
    ticker: string;
}

const CompanyFinderItem = ({ticker}: Props) => {
  return (
    <Link to={`/company/${ticker}/company-profile`} reloadDocument type='button' className='inline-flex items-center p-4 rounder-l-lg'></Link>
  )
}

export default CompanyFinderItem;