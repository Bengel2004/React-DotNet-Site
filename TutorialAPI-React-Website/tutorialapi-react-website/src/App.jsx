import Header from './Header'
import FoodCard from './Card/FoodCard';
import MyComponent from './assets/MyComponent';
import RetrieveAPI from './RetrieveAPI';
import Footer from './Footer';
//import cardPicture from '../assets/banana.jpg'


function App() {

  const fruits = [
    {id: 1, name: "Appel", description: "Dit is een appel!", picture: "https://images.immediate.co.uk/production/volatile/sites/30/2017/01/Bunch-of-bananas-67e91d5.jpg"},
    {id: 2, name: "Banaan", description: "Dit is een Banaan!", picture: "https://assets.clevelandclinic.org/transform/cd71f4bd-81d4-45d8-a450-74df78e4477a/Apples-184940975-770x533-1_jpg"}
  ];


  
  return(
    <>
      <Header/>
      <FoodCard items={fruits}/>
      <MyComponent/>
      <RetrieveAPI/>
      <Footer/>
    </>
  );
}

export default App
