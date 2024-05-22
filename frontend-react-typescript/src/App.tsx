import { Outlet } from 'react-router';
import './App.css';
import "react-toastify/dist/ReactToastify.css";
import Navbar from './Components/Navber/Navbar';
import { ToastContainer } from 'react-toastify'; // Corrected import
import { UserProvider } from './Context/useAuth';

function App() {
  return (
    <>
      <UserProvider>
        <Navbar />
        <Outlet />
        <ToastContainer />
      </UserProvider>
    </>
  );
}

export default App;

/*
  React don't allow edit existing array. It creates new array.
  Spread Operator to edit the existing array.
  filter method used to create new array without the deleted item
*/
