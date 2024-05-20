import React from 'react'
import "./Spinner.css"
import { ClipLoader } from 'react-spinners';

type Props = {
    isLoading? : boolean;
};

const Spinner = ({isLoading = true}: Props) => {
  return (
    <div id="loading-spinner">
        <ClipLoader color='#36d7d7' size={35} aria-label="Loading Spinner" loading={isLoading} data-testid="loading"/>
    </div>
  )
}

export default Spinner