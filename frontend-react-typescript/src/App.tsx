import { Outlet } from 'react-router';
import './App.css';
import Navbar from './Components/Navber/Navbar';

function App() {
  return (
    <>
    <Navbar/>
    <Outlet/>
    </>
  );
}

export default App;


/*
  React don't allow edit existing array. It creates new array.
  Sprade Operator to edit the existing array.
  filter method used to create new array without the deleted item
*/